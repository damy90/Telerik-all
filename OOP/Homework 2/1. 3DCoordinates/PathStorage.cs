using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;

//4. Create a static class PathStorage with static methods to save and load paths from a text file.
//Use a file format of your choice.

public static class PathStorage
{
    public static Path ReadPath()
    {
        var path = new Path();

        XmlSerializer x = new XmlSerializer(path.GetType());
        StreamReader file = new StreamReader(@"../../path.xml");
        path = (Path)x.Deserialize(file);
        file.Close();

        return path;
    }

    public static void SavePath(Path path)
    {
        XmlSerializer x = new XmlSerializer(path.GetType());
        StreamWriter file = new StreamWriter(@"../../path.xml");
        x.Serialize(file, path);
        file.Close();
    }
}
