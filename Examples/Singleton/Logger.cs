public class Logger {
    private static Logger instance;
    private static object lockObject = new();

    private Logger() {
        // Private constructor to prevent direct instantiation
    }

    public static Logger instance {
        get {
            if (instance == null) {
                lock (lockObject) {
                    if (instance == null) {
                        instance = new Logger();
                    }
                }
            }

            return instance;
        }
    }

    public void Log(string message) {
        // Logging implementation
        Console.WriteLine($"Logging message: {message}");
    }
}

public class Program {
    public static void Main(string[] args) {
        Logger logger = Logger.Instance;
        logger.log("This is a log message.");
    }
}