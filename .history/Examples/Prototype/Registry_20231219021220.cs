using System.Collections.Generic;

public abstract class Product {
    public abstract Product Clone();
}

public class ConcreteProductA : Product {
    public override Product Clone()
    {
        return new ConcreteProductA();
    }
}

public class ConcreteProductB : Product {
    public override Product Clone() {
        return new ConcreteProductB();
    }
}

public class ProductRegistry {
    private Dictionary<string, Product> registry = new Dictionary<string, Product>();

    public void RegisterProduct(string productId, Product product) {
        registry[productId] = product;
    }

    public Product CloneProduct(string productId) {
        if (registry.ContainsKey(productId)) {
            return registry[productId].Clone();
        }

        throw new KeyNotFoundException("Product not found in registry.");
    }
}

public class Program {
    public static void Main(string[] args) {
        ProductRegistry registry = new();

        registry.RegisterProduct("A", new ConcreteProductA());
        registry.RegisterProduct("B", new ConcreteProductB());

        Product clonedProductA = registry.CloneProduct("A");
        Product clonedProductB = registry.CloneProduct("B");
    }
}