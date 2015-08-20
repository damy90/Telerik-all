namespace Computers.Interfaces
{
    using System;

    public interface IVideoCard
    {
        // TODO: remove?
        bool IsMonochrome { get; set; }

        void Draw(string text);
    }
}
