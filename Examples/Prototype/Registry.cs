using System.Collections.Generic;

/// <summary>
/// Represents an abstract product that can be cloned.
/// </summary>
public abstract class Product {
    /// <summary>
    /// Creates a deep copy of the product.
    /// </summary>
    /// <returns>A new instance of the product.</returns>
    public abstract Product Clone();
}

/// <summary>
/// Represents a concrete implementation of the Product class.
/// </summary>
public class ConcreteProductA : Product {
    /// <summary>
    /// Creates a new instance of the ConcreteProductA class.
    /// </summary>
    /// <returns>A new instance of the ConcreteProductA class.</returns>
    public override Product Clone()
    {
        return new ConcreteProductA();
    }
}

/// <summary>
/// Represents a concrete implementation of the Product class.
/// </summary>
public class ConcreteProductB : Product {
    /// <summary>
    /// Creates a new instance of the ConcreteProductB class.
    /// </summary>
    /// <returns>A new instance of the ConcreteProductB class.</returns>
    public override Product Clone() {
        return new ConcreteProductB();
    }
}

/// <summary>
/// Represents a registry for managing product prototypes.
/// </summary>
public class ProductRegistry {
    private Dictionary<string, Product> registry = new Dictionary<string, Product>();

    /// <summary>
    /// Registers a product prototype with the specified product ID.
    /// </summary>
    /// <param name="productId">The ID of the product.</param>
    /// <param name="product">The product prototype to register.</param>
    public void RegisterProduct(string productId, Product product) {
        registry[productId] = product;
    }

    /// <summary>
    /// Clones and returns a product prototype with the specified product ID.
    /// </summary>
    /// <param name="productId">The ID of the product to clone.</param>
    /// <returns>The cloned product.</returns>
    /// <exception cref="KeyNotFoundException">Thrown when the product ID is not found in the registry.</exception>
    public Product CloneProduct(string productId) {
        if (registry.ContainsKey(productId)) {
            return registry[productId].Clone();
        }

        throw new KeyNotFoundException("Product not found in registry.");
    }
}

/// <summary>
/// Represents the entry point of the program.
/// </summary>
public class Program {
    public static void Main(string[] args) {
        ProductRegistry registry = new();

        registry.RegisterProduct("A", new ConcreteProductA());
        registry.RegisterProduct("B", new ConcreteProductB());

        Product clonedProductA = registry.CloneProduct("A");
        Product clonedProductB = registry.CloneProduct("B");
    }
}