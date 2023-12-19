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