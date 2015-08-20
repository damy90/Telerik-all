using System.Collections.Generic;

public interface IComentable
{
    List<string> Comments { get; set; }
    void AddComment(string comment);
}
