using FavChoonsLibrary;

namespace FavChoonsTests;

public class UnitTest1
{
    [Fact]
    public void InitLibrary()
    {
        TestClass testClass = new TestClass();
        Assert.Equal("TestClass", testClass.name);
    }
}
