/// <summary>
/// Represents an abstract class for processing payments.
/// </summary>
public abstract class PaymentProcessor {
    /// <summary>
    /// Processes the payment for the specified amount.
    /// </summary>
    /// <param name="amount">The amount to be processed.</param>
    public abstract void ProcessPayment(decimal amount);
}

/// <summary>
/// Represents a payment processor for credit card payments.
/// </summary>
public class CreditCardProcessor : PaymentProcessor {
    /// <summary>
    /// Processes a credit card payment for the specified amount.
    /// </summary>
    /// <param name="amount">The amount to be processed.</param>
    public override void ProcessPayment(decimal amount) {
        Console.WriteLine($"Processing credit card payment of {amount} dollars.");
        // Credit card payment processing logic
    }
}

/// <summary>
/// Represents a payment processor for PayPal payments.
/// </summary>
public class PayPalProcessor : PaymentProcessor {
    /// <summary>
    /// Processes a PayPal payment for the specified amount.
    /// </summary>
    /// <param name="amount">The amount to be processed.</param>
    public override void ProceessPayment(decimal amount) {
        Console.WriteLine($"Processing PayPal payment of {amount} dollars.");
        // PayPal payment processing logic
    }
}

public class BankAccountProcessor : PaymentProcessor {
    public override void ProcessPayment(decimal amount) {
        Console.WriteLine($"Processing Bank Account payment of {amount} dollars.");
        // Bank Account processing logic
    }
}

public class PaymentProcessorFactory {
    public PaymentProcessor CreatePaymentProcessor(string paymentMethod) {
        switch (paymentMethod) {
            case "CreditCard":
                return new CreditCardProcessor();
            case "PayPal":
                return new PayPalProcessor();
            case "BankAccount":
                return new BankAccountProcessor();
            default:
                throw new ArgumentException("Invalid payment method.", nameof(paymentMethod));
        }
    }
}

/// <summary>
/// Represents the entry point of the program.
/// </summary>
public class Program {
    public static void Main((string[] args) {
        PaymentProcessorFactory factory = new PaymentProcessorFactory();
        PaymentProcessor creditCardProcessor = factory.CreatePaymentProcessor("CreditCard");
        creditCardProcessor.ProcessPayment(100.0m);

        PaymentProcessor payPalProcessor = factory.CreatePaymentProcessor("PayPal");
        payPalProcessor.ProcessPayment(2000.0m);

        PaymentProcessor bankAccountProcessor = factory.CreatePaymentProcessor("BankAccount");
        bankAccountProcessor.ProcessPayment(10000.0m);
    }
}