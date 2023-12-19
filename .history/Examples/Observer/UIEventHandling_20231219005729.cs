using System;

public class Button {
    public event EventHandler Click;

    public void OnClick() {
        Console.WriteLine("Button clicked!");
        Click?.Invoke(this, EventArgs.Empty);
    }
}

public class Label {
    public void UpdateText(object sender, EventArgs e) {
        Console.WriteLine("Label updated with new text.");
    }
}

public class Program {
    public static void Main(string[] args) {
        Button button = new();
        Label label = new();

        button.Click += label.UpdateText;

        button.OnClick();
    }
}