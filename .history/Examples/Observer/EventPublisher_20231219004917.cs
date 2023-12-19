using System;

public class EventPublisher {
    public event EventHandler EventOccurred;

    public void DoSomething() {
        // Perform some operation
        Console.WriteLine("Doing something...");

        // Raise an event
        OnEventOccurred();
    }

    protected virtual void OnEventOccurred() {
        EventOccurred?.Invoke(this, EventArgs.Empty);
    }
}

public class EventSubscriber {
    public void Subscribe(EventPublisher publisher) {
        publisher.EventOccurred += HandleEvent;
    }

    public void Unsubscribe(EventPublisher publisher) {
        publisher.EventOccurred -= HandleEvent;
    }

    private void HandleEvent(object sender, EventArgs e) {
        Console.WriteLine("Event Occurred! Handling event...");
    }
}

public class Program {
    public static void Main(string[] args) {
        EventPublisher publisher = new();
        EventSubscriber subscriber = new();

        subscriber.Subscribe(publisher);

        publisher.DoSomething();

        subscriber.Unsubscribe(publisher);
    }
}