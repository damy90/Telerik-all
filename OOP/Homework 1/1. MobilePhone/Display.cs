public class Display
{
    public uint? Size { get; private set; }
    public uint? Colors { get; private set; }

    public Display(uint? size = null, uint? colors = null)
    {
        this.Size = size;
        this.Colors = colors;
    }
}