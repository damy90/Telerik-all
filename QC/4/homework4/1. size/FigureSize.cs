using System;

public class FigureSize
{
    private readonly double width;
    private readonly double heigth;

    public FigureSize(double width, double heigth)
    {
        this.width = width;
        this.heigth = heigth;
    }

    public static FigureSize GetRotatedSize(FigureSize size, double figureAngle)
    {
        double width = (Math.Abs(Math.Cos(figureAngle)) * size.width) + (Math.Abs(Math.Sin(figureAngle)) * size.heigth);
        double heigth = (Math.Abs(Math.Sin(figureAngle)) * size.width) + (Math.Abs(Math.Cos(figureAngle)) * size.heigth);

        return new FigureSize(width, heigth);
    }
}