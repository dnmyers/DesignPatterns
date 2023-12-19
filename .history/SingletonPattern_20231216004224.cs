// Ensures that a class hass only one instance and
// provides a global point of access to that instance.

public class Singleton {
    private static Singleton instance;

    private Singleton() { }

    public static Singleton Instance {
        get {
            if (instance == null) {
                instance = new Singleton();
            }

            return instance;
        }
    }
}