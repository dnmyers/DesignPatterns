public interface IBuilder {
    void BuildPartA();
    void BuildPartB();
    void BuildPartC();
    Product GetResult();
}

public class ConcreteBuilder : IBuilder {
    private Product product = new Product();

    public void BuildPartA() {
        product.Add("PartA");
    }

    public void BuildPartB() {
        product.Add("PartB");
    }

    public void BuildPartC() {
        product.Add("PartC");
    }

    public Product GetResult() {
        return product;
    }
}

public class Product {
    private List<string> parts = new List<string>();

    public void Add(string part) {
        parts.Add(part);
    }

    public void Show() {
        Console.WriteLine("\nProduct Parts -------");

        foreach (string part in parts) {
            Console.WriteLine(part);
        }
    }
}