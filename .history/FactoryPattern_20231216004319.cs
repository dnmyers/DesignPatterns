// Defines an interface for creating an object, but
// lets subclasses decide which class to instantiate

public interface IShape {
    void Draw();
}

public class Circle : IShape {
    public void Draw() {
        Console.WriteLine("Inside Circle::Draw() method.");
    }
}

public class Rectangle : IShape {
    public void Draw() {
        Console.WriteLine("Inside Rectangle::Draw() method.");
    }
}

public class ShapeFactory {
    public IShape GetShape(string shapeType) {
        if (shapeType == "Circle") {
            return new Circle();
        } else if (shapeType == "Rectangle") {
            return new Rectangle();
        }

        return null;
    }
}