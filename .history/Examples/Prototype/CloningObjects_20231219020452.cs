public abstract class Shape {
    public abstract Shape Clone();
}

public class Circle : Shape {
    public int Radius { get; set; }

    public override Shape Clone()
    {
        return new Circle { Radius = this.Radius };
    }
}

public class Rectangle : Shape {
    public int Width {get; set; }
    public int Height { get; set; }

    public override Shape Clone()
    {
        return new Rectangle { Width = this.Width, Height = this.Height };
    }
}

public class Program {
    public static void Main(string[] args) {
        Shape originalCircle = new Circle { Radius = 5 };
        Shape clonedCircle = originalCircle.Clone();

        Shape originalRectangle = new Rectangle { Width = 10, Height = 7 };
        Shape clonedRectangle = originalRectangle.Clone();
    }
}