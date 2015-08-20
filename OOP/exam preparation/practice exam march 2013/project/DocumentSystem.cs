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
        // TODO
    }

    private static void AddPdfDocument(string[] attributes)
    {
        // TODO
    }

    private static void AddWordDocument(string[] attributes)
    {
        // TODO
    }

    private static void AddExcelDocument(string[] attributes)
    {
        // TODO
    }

    private static void AddAudioDocument(string[] attributes)
    {
        // TODO
    }

    private static void AddVideoDocument(string[] attributes)
    {
        // TODO
    }

    private static void ListDocuments()
    {
        // TODO
    }

    private static void EncryptDocument(string name)
    {
        // TODO
    }

    private static void DecryptDocument(string name)
    {
        // TODO
    }

    private static void EncryptAllDocuments()
    {
        // TODO
    }

    private static void ChangeContent(string name, string content)
    {
        // TODO
    }
}

public class Document:IDocument
{
    public string Name { get; protected set; }

    public string Content { get; protected set; }

    public void LoadProperty(string key, string value)
    {
        if (key == "name")
            this.Name = value;
        if (key == "name")
            this.Content = value;
    }

    public void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("name", Name));
        output.Add(new KeyValuePair<string, object>("content", Content));
    }

    public override string ToString()
    {
        IList<KeyValuePair<string, object>> properties=new IList<KeyValuePair<string, object>>();
        SaveAllProperties(properties);
        StringBuilder result = new StringBuilder();
        //result.AppendFormat("{0}: {1}\n{2}: {3}\n", "name", Name, "content", Content);
        foreach (property in properties)
        {
            if(propperty.Value)bjnb
        }
        return result.ToString();
    }
}
public class TextDocument : Document
{

}
public class BinaryDocument:Document
{

}