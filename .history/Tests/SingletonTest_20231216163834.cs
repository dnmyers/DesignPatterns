using NUnit.Framework;
using System;

// FILEPATH: /e:/Coding/.NET/C#/DesignPatterns/SingletonPatternTests.cs

[TestFixture]
public class SingletonTests {
    [Test]
    public void SingletonInstance_IsNotNull() {
        // Arrange & Act
        var instance = Singleton.Instance;

        // Assert
        Assert.IsNotNull(instance);
    }

    [Test]
    public void SingletonInstance_IsSameReference() {
        // Arrange
        var instance1 = Singleton.Instance;
        var instance2 = Singleton.Instance;

        // Assert
        Assert.AreSame(instance1, instance2);
    }

    [Test]
    public void SingletonInstance_IsSameValue() {
        // Arrange
        var instance1 = Singleton.Instance;
        var instance2 = Singleton.Instance;

        // Assert
        Assert.AreEqual(instance1, instance2);
    }
}