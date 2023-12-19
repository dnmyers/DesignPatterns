// Provides a surrogate or placeholder for another object to control access to it.
// Provides a level of indirection when accessing an object, controls access to the object,
// decouples the client from the object, and adds functionality such as lazy initialization or access control.

// The code snippet demonstrates the use of the proxy pattern, which provides a surrogate or placeholder for another object to control access to it.
// The proxy pattern is used to control access to an object. The proxy can be used to add functionality such as lazy initialization or access control.
// The proxy pattern is also known as the surrogate pattern.

// How to Implement:
// Create a proxy class that wraps the original object and forwards requests to it, optionally adding its own functionality.

// Pros:
// Provides a level of indirection when accessing an object.
// Controls access to the object.
// Decouples the client from the object.
// Adds functionality such as lazy initialization or access control.

// Cons:
// Increases the complexity of the code.
// The response from the service can be slower.

// Subject interface:
interface ISubject {
    void Request();
}

// Real subject:
class RealSubject : ISubject {
    public void Request() {
        Console.WriteLine("RealSubject: Handling Request");
    }
}

// Proxy:
class Proxy : ISubject {
    private RealSubject _realSubject;

    public void Request() {
        if (_realSubject == null) {
            Console.WriteLine("Proxy: Creating RealSubject");
            _realSubject = new RealSubject();
        }

        Console.WriteLine("Proxy: Handling Request");
        _realSubject.Request();
    }
}

// Client:
class Client {
    static void Main() {
        Proxy proxy = new();
        proxy.Request();
    }
}