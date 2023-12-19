// Provides a unified interface to a set of interfaces in a subsystem, making it easier to use.
// Simplifies the complexities of a system, provides a unified interface to a set of interfaces,
// and decouples the client from the subsystem.


// The code snippet demonstrates the use of the facade pattern, which provides a unified interface to a set of interfaces in a subsystem.
// Subsystem:
public class SubsystemA {
    public void OperationA() {
        Console.WriteLine("SubsystemA Operation");
    }
}

public class SubsystemB {
    public void OperationB() {
        Console.WriteLine("SubsystemB Operation");
    }
}

// Facade:
class Facade {
    private SubsystemA _subsystemA = new();
    private SubsystemB _subsystemB = new();

    public void Operation() {
        _subsystemA.OperationA();
        _subsystemB.OperationB();
    }
}

// Client:
class Client {
    static void Main() {
        Facade facade = new();
        facade.Operation();
    }
}