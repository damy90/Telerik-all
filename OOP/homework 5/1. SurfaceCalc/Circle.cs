using System;
class Circle:Shape
{
    public Circle(int heigth) : base(heigth) { }
    public override float CaslculateSurface()
    {
        return (float)(Math.PI)*Heigth*Heigth/4;
    }
}
