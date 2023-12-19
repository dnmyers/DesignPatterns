public abstract class PaymentProcessor {
    public abstract void ProcessPayment(decimal amount);
}

public class CreditCardProcessor : PaymentProcessor {
    public override void ProcessPayment(decimal amount) {
        Console.WriteLine($"Processing credit card payment of {amount} dollars.");
        // Credit card payment processing logic
    }
}

public class PayPalProcessor : PaymentProcessor {
    public override void ProceessPayment(decimal amount) {
        Console.WriteLine($"Processing PayPal payment of {amount} dollars.");
        // PayPal payment processing logic
    }
}

public class PaymentProcessorFactory {
    public PaymentProcessor CreatePaymentProcessor(string paymentMethod) {
        switch (paymentMethod) {
            case "CreditCard":
                return new CreditCardProcessor();
            case "PayPal":
                return new PayPalProcessor();
            default:
                throw new ArgumentException("Invalid payment method.", nameof(paymentMethod));
        }
    }
}

public class Program {
    public static void Main((string[] args) {
        PaymentProcessorFactory factory = new PaymentProcessorFactory();
        PaymentProcessor creditCardProcessor = factory.CreatePaymentProcessor("CreditCard");
        processor.ProcessPayment(100.0m);

        PaymentProcessor payPalProcessor = factory.CreatePaymentProcessor("PayPal");
        payPalProcessor.ProcessPayment(2000.0m);
    }
}