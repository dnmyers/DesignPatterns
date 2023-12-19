// Allows the interface of an existing class to be
// used as another interface. It is often used to make
// existing classes work with others without modifying their source code.

public interface ITarget {
    void Request();
}

public class Adaptee {
    public void SpecificRequest() {
        Console.WriteLine("Adaptee specific request");
    }
}

public class Adapter : ITarget {
    private Adaptee adaptee = new Adaptee();

    public void Request() {
        adaptee.SpecificRequest();
    }
}