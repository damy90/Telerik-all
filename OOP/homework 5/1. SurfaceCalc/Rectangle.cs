class Rectangle : Shape
{
    public Rectangle(int width, int heigth) : base(width, heigth) { }
    public override float CaslculateSurface()
    {
        return Heigth * Width;
    }
}
