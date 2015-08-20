class Triangle:Shape
{
    public Triangle(int width, int heigth) : base(width, heigth) { }
    public override float CaslculateSurface()
    {
        return Heigth * Width / 2;
    }
}
