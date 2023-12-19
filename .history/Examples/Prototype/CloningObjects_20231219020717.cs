/// <summary>
/// Represents an abstract shape.
/// </summary>
public abstract class Shape {
    /// <summary>
    /// Creates a deep copy of the shape.
    /// </summary>
    /// <returns>A new instance of the shape.</returns>
    public abstract Shape Clone();
}

/// <summary>
/// Represents a circle shape.
/// </summary>
public class Circle : Shape {
    /// <summary>
    /// Gets or sets the radius of the circle.
    /// </summary>
    public int Radius { get; set; }

    /// <summary>
    /// Creates a new instance of the Circle class with the same radius.
    /// </summary>
    /// <returns>A new Circle object with the same radius.</returns>
    public override Shape Clone()
    {
        return new Circle { Radius = this.Radius };
    }
}

/// <summary>
/// Represents a rectangle shape.
/// </summary>
public class Rectangle : Shape {
    /// <summary>
    /// Gets or sets the width of the rectangle.
    /// </summary>
    public int Width {get; set; }

    /// <summary>
    /// Gets or sets the height of the rectangle.
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// Creates a new instance of the Rectangle class with the same width and height.
    /// </summary>
    /// <returns>A new Rectangle object.</returns>
    public override Shape Clone()
    {
        return new Rectangle { Width = this.Width, Height = this.Height };
    }
}

/// <summary>
/// Represents the entry point of the program.
/// </summary>
public class Program {
    public static void Main(string[] args) {
        Shape originalCircle = new Circle { Radius = 5 };
        Shape clonedCircle = originalCircle.Clone();

        Shape originalRectangle = new Rectangle { Width = 10, Height = 7 };
        Shape clonedRectangle = originalRectangle.Clone();
    }
}