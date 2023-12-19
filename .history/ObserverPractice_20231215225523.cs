// Create a simple Observer pattern implementation for monitoring stock prices.
// The MonitorStock class is the subject and the StockObserver class is the observer.

public interface IObserver {
    void Update(string message);
}

public interface IMonitor {
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}

public class MonitorStock : IMonitor {
    private List<IObserver> observers = new List<IObserver>();
    private double price;

    public double Price {
        get { return price; }
        set {
            price = value;
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
        foreach (IObserver observer in observers) {
            observer.Update(price);
        }
    }
}

// StockObserver class
public class StockObserver : IObserver {
    private string name;
    private double price;

    public StockObserver(string name) {
        this.name = name;
    }

    public void Update(double price) {
        this.price = price;
        Console.WriteLine("Price at {0} is now {1}", name, price);
    }

    public double Price {
        get { return price; }
    }

    public string Name {
        get { return name; }
    }

    public void Display() {
        Console.WriteLine("Price at {0} is now {1}", name, price);
    }

    public void Display(string message) {
        Console.WriteLine(message);
    }

    public void Display(string message, double price) {
        Console.WriteLine(message, name, price);
    }

    public void Display(string message, string name, double price) {
        Console.WriteLine(message, name, price);
    }

    public void Display(string message, string name, double price, string date) {
        Console.WriteLine(message, name, price, date);
    }

    public void Display(string message, string name, double price, string date, string time) {
        Console.WriteLine(message, name, price, date, time);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone) {
        Console.WriteLine(message, name, price, date, time, timeZone);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone, string currency) {
        Console.WriteLine(message, name, price, date, time, timeZone, currency);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone, string currency, string exchange) {
        Console.WriteLine(message, name, price, date, time, timeZone, currency, exchange);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone, string currency, string exchange, string country) {
        Console.WriteLine(message, name, price, date, time, timeZone, currency, exchange, country);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone, string currency, string exchange, string country, string sector) {
        Console.WriteLine(message, name, price, date, time, timeZone, currency, exchange, country, sector);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone, string currency, string exchange, string country, string sector, string industry) {
        Console.WriteLine(message, name, price, date, time, timeZone, currency, exchange, country, sector, industry);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone, string currency, string exchange, string country, string sector, string industry, string marketCap) {
        Console.WriteLine(message, name, price, date, time, timeZone, currency, exchange, country, sector, industry, marketCap);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone, string currency, string exchange, string country, string sector, string industry, string marketCap, string volume) {
        Console.WriteLine(message, name, price, date, time, timeZone, currency, exchange, country, sector, industry, marketCap, volume);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone, string currency, string exchange, string country, string sector, string industry, string marketCap, string volume, string avgVolume) {
        Console.WriteLine(message, name, price, date, time, timeZone, currency, exchange, country, sector, industry, marketCap, volume, avgVolume);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone, string currency, string exchange, string country, string sector, string industry, string marketCap, string volume, string avgVolume, string peRatio) {
        Console.WriteLine(message, name, price, date, time, timeZone, currency, exchange, country, sector, industry, marketCap, volume, avgVolume, peRatio);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone, string currency, string exchange, string country, string sector, string industry, string marketCap, string volume, string avgVolume, string peRatio, string eps) {
        Console.WriteLine(message, name, price, date, time, timeZone, currency, exchange, country, sector, industry, marketCap, volume, avgVolume, peRatio, eps);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone, string currency, string exchange, string country, string sector, string industry, string marketCap, string volume, string avgVolume, string peRatio, string eps, string week52High) {
        Console.WriteLine(message, name, price, date, time, timeZone, currency, exchange, country, sector, industry, marketCap, volume, avgVolume, peRatio, eps, week52High);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone, string currency, string exchange, string country, string sector, string industry, string marketCap, string volume, string avgVolume, string peRatio, string eps, string week52High, string week52Low) {
        Console.WriteLine(message, name, price, date, time, timeZone, currency, exchange, country, sector, industry, marketCap, volume, avgVolume, peRatio, eps, week52High, week52Low);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone, string currency, string exchange, string country, string sector, string industry, string marketCap, string volume, string avgVolume, string peRatio, string eps, string week52High, string week52Low, string dayHigh) {
        Console.WriteLine(message, name, price, date, time, timeZone, currency, exchange, country, sector, industry, marketCap, volume, avgVolume, peRatio, eps, week52High, week52Low, dayHigh);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone, string currency, string exchange, string country, string sector, string industry, string marketCap, double volume, string avgVolume, string peRatio, string eps, string week52High, string week52Low, string dayHigh, string dayLow) {
        Console.WriteLine(message, name, price, date, time, timeZone, currency, exchange, country, sector, industry, marketCap, volume, avgVolume, peRatio, eps, week52High, week52Low, dayHigh, dayLow);
    }
}

// StockObserver class
public class StockObserver2 : IObserver {
    private string name;
    private double price;

    public StockObserver2(string name) {
        this.name = name;
    }

    public void Update(double price) {
        this.price = price;
        Console.WriteLine("Price at {0} is now {1}", name, price);
    }

    public double Price {
        get { return price; }
    }

    public string Name {
        get { return name; }
    }

    public void Display() {
        Console.WriteLine("Price at {0} is now {1}", name, price);
    }

    public void Display(string message) {
        Console.WriteLine(message);
    }

    public void Display(string message, double price) {
        Console.WriteLine(message, name, price);
    }

    public void Display(string message, string name, double price) {
        Console.WriteLine(message, name, price);
    }

    public void Display(string message, string name, double price, string date) {
        Console.WriteLine(message, name, price, date);
    }

    public void Display(string message, string name, double price, string date, string time) {
        Console.WriteLine(message, name, price, date, time);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone) {
        Console.WriteLine(message, name, price, date, time, timeZone);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone, string currency) {
        Console.WriteLine(message, name, price, date, time, timeZone, currency);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone, string currency, string exchange) {
        Console.WriteLine(message, name, price, date, time, timeZone, currency, exchange);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone, string currency, string exchange, string country) {
        Console.WriteLine(message, name, price, date, time, timeZone, currency, exchange, country);
    }

    public void Display(string message, string name, double price, string date, string time, string timeZone, string currency, string exchange, string country, string sector) {
        Console.WriteLine(message, name, price, date, time, timeZone, currency, exchange, country, sector);
    }
}

// Implement the Observer pattern for a simple stock ticker.
// The StockTicker class is the subject and the StockTickerObserver class is the observer.
