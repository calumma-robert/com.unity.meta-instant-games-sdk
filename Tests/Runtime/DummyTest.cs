using NUnit.Framework;

/// <summary>
/// This is a dummy test class
/// NOTE: All Runtime code is tested by the pure .NET unit tests.
/// </summary>
[TestFixture]
public class DummyTest
{
    /// <summary>
    /// This is a dummy test function that passes
    /// </summary>
    [Test]
    public void CanAssert()
    {
        Assert.That(true, Is.True);
    }
}
