public class ConnectionPool {
    private static ConnectionPool instance;
    private static object lockObject = new();

    private ConnectionPool() {
        // Private constructor to prevent direct instantiation
    }

    public static ConnectionPool Instance {
        get {
            if (instance == null) {
                lock (lockObject) {
                    if (instance == null) {
                        instance = new ConnectionPool();
                    }
                }
            }

            return instance;
        }
    }

    public void GetConnection() {
        // Get a database connection from the pool
        Console.WriteLine("Getting a database connection...");
    }
}

public class Program {
    public static void Main(string[] args) {
        ConnectionPool connectionPool = ConnectionPool.Instance;
        connectionPool.GetConnection();
    }
}