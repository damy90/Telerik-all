//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.

abstract class Shape
{
    protected int Heigth { get; set; }
    protected int Width { get; set; }

    public Shape(int heigth) : this(heigth, 0) { }
    public Shape(int heigth, int width)
    {
        if (heigth < 0 || width < 0)
            throw new InvalidDimentionValueException("Dimentions must be positive numbers");
        this.Heigth = heigth;
        this.Width = width;
    }

    public abstract float CaslculateSurface();
}
