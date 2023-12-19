public interface IShape {
    void Draw();
}

public class Rectangle : IShape {
    public void Draw() {
        Console.WriteLine("Draw Rectangle");
    }
}

public class Circle : IShape {
    public void Draw() {
        Console.WriteLine("Draw Circle");
    }
}

public class Triangle : IShape {
    public void Draw() {
        Console.WriteLine("Draw Triangle");
    }
}

public class ShapeFactory {
    public IShape GetShape(string shapeType) {
        switch(shapeType) {
            case "Rectangle":
                return new Rectangle();
                break;
            case "Circle":
                return new Circle();
                break;
            case "Triangle":
                return new Triangle();
                break;
            default:
                return null;
                break;
        }
    }
}

class Program {
    static void Main(string[] args) {
        ShapeFactory shapeFactory = new ShapeFactory();

        // Create instances of different shapes
        IShape rectangle = shapeFactory.GetShape("Rectangle");
        IShape circle = shapeFactory.GetShape("Circle");
        IShape triangle = shapeFactory.GetShape("Triangle");

        // Call the Draw method of each shape
        rectangle.Draw();
        circle.Draw();
        triangle.Draw();
    }
}