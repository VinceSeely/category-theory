using project;
using System.Security.Principal;

namespace testing;

public class Tests
{

    [Test]
    public void Test1()
    {
        Assert.That(Chapter1Challenges<int>.Identity(2), Is.EqualTo(2));
    }

    [Test]
    public void Test2()
    {
        int f(int x) => x + 2;
        int g(int x) => x - 5;

        Assert.That(Chapter1Challenges<int>.Compose(f, g)(6), Is.EqualTo(3));
    }

    [Test]
    public void Test3()
    {
        int f(int x) => x + 2;
        int g(int x) => x - 5;

        Assert.That(Chapter1Challenges<int>.Compose(g, f)(6), Is.EqualTo(3));
    }

    [Test]
    public void Test4()
    {
        int f(int x) => x + 2;
        int g(int x) => x - 5;

        Assert.That(f(g(6)), Is.EqualTo(3));
    }


    [Test]
    public void Test5()
    {
        int f(int x) => x + 2;
        int g(int x) => x - 5;

        Assert.That(g(f(6)), Is.EqualTo(3));
    }
}