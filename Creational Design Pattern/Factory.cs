interface IDraw
{
    void Draw();
}


class Rectangle : IDraw
{
    public void Draw()
    {
        Console.WriteLine("Rectangle Drawing");
    }
}

class Triangle : IDraw
{
    public void Draw()
    {
        Console.WriteLine("Triangle Drawing");
    }
}

class Circle : IDraw
{
    public void Draw()
    {
        Console.WriteLine("Circle Drawing");
    }
}

class ShapeDraw //Factory function since it is generating the classes that implements our interface
{
    public IDraw Shape(string shapeType)
    {
        if(shapeType == null)
        {
            return null;
        }
        if(shapeType == "Rectangle")
        {
            return new Rectangle();
        }
        else if (shapeType == "Triangle")
        {
            return new Triangle();
        }
        else if(shapeType == "Circle")
        {
            return new Circle();
        }

        return null;
    }
}


public class FactoryProgramme
{
    //public static void Main()
    //{
    //    ShapeDraw shapeDraw = new ShapeDraw();

    //    IDraw drawingTriangle = shapeDraw.Shape("Triangle");
    //    drawingTriangle.Draw();

    //    IDraw drawingCircle = shapeDraw.Shape("Circle");
    //    drawingCircle.Draw();

    //    IDraw drawingRectangle = shapeDraw.Shape("Rectangle");
    //    drawingRectangle.Draw();
    //}
}