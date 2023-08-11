using FavChoonsLibrary;

namespace FavChoonsTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(false);
    }


    [Fact]
    public void InitLibrary()
    {
        TestClass testClass = new TestClass();
        Assert.Equal("TestClass", testClass.name);
    }
}
