// Attaches additional responsibilities to an object dynamically,
// providing a flexible alternative to subclassing for extending functionality

// The code snippet demonstrates the use of the decorator pattern, which allows for adding new functionalities to an object dynamically without the need for subclassing.
public interface IComponent {
    void Operation();
}

public class ConcreteComponent : IComponent {
    public void Operation() {
        Console.WriteLine("Concrete Component Operation");
    }
}

public abstract class Decorator : IComponent {
    protected IComponent component;

    public Decorator(IComponent component) {
        this.component = component;
    }

    public virtual void Operation() {
        component.Operation();
    }
}
