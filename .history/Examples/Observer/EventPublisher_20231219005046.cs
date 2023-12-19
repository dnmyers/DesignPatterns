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

/// <summary>
/// Represents a subscriber that can subscribe to an event published by an <see cref="EventPublisher"/>.
/// </summary>
public class EventSubscriber {
    /// <summary>
    /// Subscribes to the event published by the specified <paramref name="publisher"/>.
    /// </summary>
    /// <param name="publisher">The <see cref="EventPublisher"/> to subscribe to.</param>
    public void Subscribe(EventPublisher publisher) {
        publisher.EventOccurred += HandleEvent;
    }

    /// <summary>
    /// Unsubscribes from the event published by the specified <paramref name="publisher"/>.
    /// </summary>
    /// <param name="publisher">The <see cref="EventPublisher"/> to unsubscribe from.</param>
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