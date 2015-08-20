using System;
using System.Collections.Generic;
using System.Text;

public interface IDocument
{
    string Name { get; }
    string Content { get; }
    void LoadProperty(string key, string value);
    void SaveAllProperties(IList<KeyValuePair<string, object>> output);
    string ToString();
}

public interface IEditable
{
    void ChangeContent(string newContent);
}

public interface IEncryptable
{
    bool IsEncrypted { get; }
    void Encrypt();
    void Decrypt();
}

public class DocumentSystem
{
    private static List<IDocument> documents = new List<IDocument>();
    static void Main()
    {
        IList<string> allCommands = ReadAllCommands();
        ExecuteCommands(allCommands);
    }

    private static IList<string> ReadAllCommands()
    {
        List<string> commands = new List<string>();
        while (true)
        {
            string commandLine = Console.ReadLine();
            if (commandLine == "")
            {
                // End of commands
                break;
            }
            commands.Add(commandLine);
        }
        return commands;
    }

    private static void ExecuteCommands(IList<string> commands)
    {
        foreach (var commandLine in commands)
        {
            int paramsStartIndex = commandLine.IndexOf("[");
            string cmd = commandLine.Substring(0, paramsStartIndex);
            int paramsEndIndex = commandLine.IndexOf("]");
            string parameters = commandLine.Substring(
                paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
            ExecuteCommand(cmd, parameters);
        }
    }

    private static void ExecuteCommand(string cmd, string parameters)
    {
        string[] cmdAttributes = parameters.Split(
            new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        if (cmd == "AddTextDocument")
        {
            AddTextDocument(cmdAttributes);
        }
        else if (cmd == "AddPDFDocument")
        {
            AddPdfDocument(cmdAttributes);
        }
        else if (cmd == "AddWordDocument")
        {
            AddWordDocument(cmdAttributes);
        }
        else if (cmd == "AddExcelDocument")
        {
            AddExcelDocument(cmdAttributes);
        }
        else if (cmd == "AddAudioDocument")
        {
            AddAudioDocument(cmdAttributes);
        }
        else if (cmd == "AddVideoDocument")
        {
            AddVideoDocument(cmdAttributes);
        }
        else if (cmd == "ListDocuments")
        {
            ListDocuments();
        }
        else if (cmd == "EncryptDocument")
        {
            EncryptDocument(parameters);
        }
        else if (cmd == "DecryptDocument")
        {
            DecryptDocument(parameters);
        }
        else if (cmd == "EncryptAllDocuments")
        {
            EncryptAllDocuments();
        }
        else if (cmd == "ChangeContent")
        {
            ChangeContent(cmdAttributes[0], cmdAttributes[1]);
        }
        else
        {
            throw new InvalidOperationException("Invalid command: " + cmd);
        }
    }

    private static void AddTextDocument(string[] attributes)
    {
        AddDocument(new TextDocument(), attributes);
    }

    private static void AddPdfDocument(string[] attributes)
    {
        AddDocument(new PDFDocument(), attributes);
    }

    private static void AddWordDocument(string[] attributes)
    {
        AddDocument(new WordDocoument(), attributes);
    }

    private static void AddExcelDocument(string[] attributes)
    {
        AddDocument(new ExelDocument(), attributes);
    }

    private static void AddAudioDocument(string[] attributes)
    {
        AddDocument(new AudioDocument(), attributes);
    }

    private static void AddVideoDocument(string[] attributes)
    {
        AddDocument(new VideoDocument(), attributes);
    }

    private static void AddDocument(IDocument document,string[] attributes)
    {
        foreach (string atribute in attributes)
        {
            string[] keyAndValue = atribute.Split(new char[] { '=' }, StringSplitOptions.None);
            document.LoadProperty(keyAndValue[0], keyAndValue[1]);
        }
        if (document.Name!=null)
        {
            documents.Add(document);
            Console.WriteLine("Document added: {0}", document.Name);
        }
        else Console.WriteLine("Document has no name");
    }

    private static void ListDocuments()
    {
        if (documents.Count > 0)
            foreach (var document in documents)
                Console.WriteLine(document);

        else Console.WriteLine("No documents found");
    }

    private static void EncryptDocument(string name)
    {
        bool docFound = false;
        foreach(var document in documents)
        {
            if(document.Name==name)
            {
                if(document is IEncryptable)
                {
                    //once or every document?
                    ((IEncryptable)document).Encrypt();
                    Console.WriteLine("Document encrypted: {0}", name);
                }
                else Console.WriteLine("Document does not support encryption: {0}", name);
                docFound = true;
            }
        }
        if (!docFound)
            Console.WriteLine("Document not found: {0}", name);
    }

    private static void DecryptDocument(string name)
    {
        bool docFound = false;
        foreach (var document in documents)
        {
            if (document.Name == name)
            {
                if (document is IEncryptable)
                {
                    ((IEncryptable)document).Decrypt();
                    Console.WriteLine("Document decrypted: {0}", name);
                }
                else Console.WriteLine("Document does not support decryption: {0}", name);
                docFound = true;
            }
        }
        if (!docFound)
            Console.WriteLine("Document not found: {0}", name);
    }

    private static void EncryptAllDocuments()
    {
        bool encryptableDocFound = false;
        foreach (var document in documents)
        {
            if (document is IEncryptable)
            {
                ((IEncryptable)document).Encrypt();
                encryptableDocFound = true;
            }
        }
        if (encryptableDocFound)
            Console.WriteLine("All documents encrypted");
        else Console.WriteLine("No encryptable documents found");
    }

    private static void ChangeContent(string name, string content)
    {
        bool docFound = false;
        foreach (var document in documents)
        {
            if (document.Name==name)
            {
                docFound = true;
                if (document is IEditable)
                {
                    ((IEditable)document).ChangeContent(content);
                    Console.WriteLine("Document content changed: {0}", name);
                }
                else Console.WriteLine("Document is not editable: {0}", name);
            }
            
        }
        if (!docFound)
            Console.WriteLine("Document not found: {0}", name);
    }
}

public class Document : IDocument
{
    //mandatory
    public string Name { get; protected set; }
    //immutable
    public string Content { get; protected set; }

    public virtual void LoadProperty(string key, string value)
    {
        if (key == "name")
            this.Name = value;
        else if (key == "content")
            this.Content = value;
        else throw new ApplicationException("Key '" + key + "' not found");
    }

    public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("name", Name));
        output.Add(new KeyValuePair<string, object>("content", Content));
    }

    public override string ToString()
    {
        List<KeyValuePair<string, object>> properties=new List<KeyValuePair<string, object>>();
        SaveAllProperties(properties);
        properties.Sort((a, b) => a.Key.CompareTo(b.Key));
        StringBuilder result = new StringBuilder();
        result.AppendFormat("{0}{1}", this.GetType().Name, "[");
        bool first = true;
        foreach (var prop in properties)
        {
            if (prop.Value != null)
            {
                if (!first)
                {
                    result.Append(";");
                }
                //if last ???
                result.AppendFormat("{0}={1}", prop.Key, prop.Value);
                first = false;
            }
        }
        result.Append("]");
        return result.ToString();
    }
}
public class TextDocument : Document, IEditable
{
    public string CharSet { get; private set; }
    public override void LoadProperty(string key, string value)
    {
        if (key == "charset")
            this.CharSet = value;
        else base.LoadProperty(key, value);
    }
    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("charset", CharSet));
    }
    public void ChangeContent(string newContent)
    {
 	    Content=newContent;
    }
}

public class BinaryDocument : Document
{
    public long? Size { get; private set; }
    public override void LoadProperty(string key, string value)
    {
        if (key == "size")
            this.Size = long.Parse(value);
        else base.LoadProperty(key, value);
    }
    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("size", Size));
    }
}

public abstract class EncryptableBinaryDocument : BinaryDocument, IEncryptable
{
    private bool isEncrypted = false;

    public bool IsEncrypted
    {
        get { return this.isEncrypted; }
    }

    public void Encrypt()
    {
        this.isEncrypted = true;
    }

    public void Decrypt()
    {
        this.isEncrypted = false;
    }

    public override string ToString()
    {
        if (this.isEncrypted)
            return String.Format("{0}[encrypted]", this.GetType().Name);

        else return base.ToString();
    }
}
public class PDFDocument : EncryptableBinaryDocument
{
    public long? PagesCount { get; private set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "pages")
            this.PagesCount = long.Parse(value);
        else base.LoadProperty(key, value);
    }
    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("pages", PagesCount));
    }
}

public class OfficeDocument : EncryptableBinaryDocument
{
    public string Version { get; private set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "version")//		key	"version"	string
            this.Version = value;
        else base.LoadProperty(key, value);
    }
    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("version", Version));
    }
}
public class WordDocoument : OfficeDocument, IEditable
{
    public long? CharsCount { get; private set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "chars")
            this.CharsCount = long.Parse(value);
        else base.LoadProperty(key, value);
    }
    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("chars", CharsCount));
    }

    public void ChangeContent(string newContent)
    {
 	    Content=newContent;
    }
}
public class ExelDocument : OfficeDocument
{
    public long? Rows { get; private set; }
    public long? Cols { get; private set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "rows")
            this.Rows = long.Parse(value);
        else if (key == "cols")
            this.Cols = long.Parse(value);
        else base.LoadProperty(key, value);
    }
    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("rows", Rows));
        output.Add(new KeyValuePair<string, object>("cols", Cols));
    }
}

public class MultimediaDocument:BinaryDocument
{
    public long? Length { get; private set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "length")
            this.Length = long.Parse(value);
        else base.LoadProperty(key, value);
    }
    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("length", Length));
    }
}
public class VideoDocument:MultimediaDocument
{
    public long? FrameRate { get; private set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "framerate")
            this.FrameRate = long.Parse(value);
        else base.LoadProperty(key, value);
    }
    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("framerate", FrameRate));
    }
}
public class AudioDocument : MultimediaDocument
{
    public long? SampleRate { get; private set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "samplerate")
            this.SampleRate = long.Parse(value);
        else base.LoadProperty(key, value);
    }
    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("samplerate", SampleRate));
    }
}