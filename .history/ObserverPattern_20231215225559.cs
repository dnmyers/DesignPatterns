public interface IObserver {
    void Update(string message);
}

public interface ISubject {
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}

public class MessagePublisher : ISubject {
    private List<IObserver> observers = new List<IObserver>();
    private string message;

    public string Message {
        get { return message; }
        set {
            message = value;
            Notify();
        }
    }

    public void Attach(IObserver observer) {
        observers.Add(observer);
    }

    public void Detach(IObserver observer) {
        observers.Remove(observer);
    }

    public void Notify() {
        foreach(var observer in observers) {
            observer.Update(message);
        }
    }
}


// Below from copilot
public class Subject : ISubject {
    private List<IObserver> observers = new List<IObserver>();
    private string message;

    public void Attach(IObserver observer) {
        observers.Add(observer);
    }

    public void Detach(IObserver observer) {
        observers.Remove(observer);
    }

    public void Notify() {
        foreach (IObserver observer in observers) {
            observer.Update(message);
        }
    }

    public void SetState(string message) {
        this.message = message;
        Notify();
    }
}