using System;

public class EventPublisher {
    public event EventHandler EventOccurred;

    public void DoSomething() {
        // Perform some operation
        Console.WriteLine("Doing something...");

        // Raise an event
        OnEventOccurred();
    }
}