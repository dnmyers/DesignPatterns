using System;

/// <summary>
/// Represents a button control.
/// </summary>
public class Button {
    public event EventHandler Click;

    /// <summary>
    /// Raises the Click event.
    /// </summary>
    public void OnClick() {
        Console.WriteLine("Button clicked!");
        Click?.Invoke(this, EventArgs.Empty);
    }
}

/// <summary>
/// Represents a label control.
/// </summary>
public class Label {
    /// <summary>
    /// Updates the text of the label.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">The event arguments.</param>
    public void UpdateText(object sender, EventArgs e) {
        Console.WriteLine("Label updated with new text.");
    }
}

/// <summary>
/// Represents the entry point of the program.
/// </summary>
public class Program {
    public static void Main(string[] args) {
        Button button = new();
        Label label = new();

        // Subscribe the UpdateText method of the label object
        // to the Click event of the button object so that when
        // the Click event is triggered, the UpdateText method
        // will be executed.
        button.Click += label.UpdateText;

        button.OnClick();
    }
}