

namespace Banking.Tests.Syntax;
public class Types
{
    string Name = "Bob";

    [Fact]
    public void DeclaringVariables()
    {
        // type identifier [=initializer]
        //int age;
        //age = 55;

        var age = 55;
        var yourAge = 16.5;

        var myHourlyPay = 18.23M; // declare a local variable of type Decimal, with the initial value of ...

        //if(DateTime.Now.Date == new DateTime(4, 20, 2025))
        //{
        //    age += 1;
        //}

        // a variable in a strictly types language cannot change it's type

        Assert.Equal("Bob", Name);
        Assert.Equal(55, age);
    }

    [Fact]
    public void AnotherThing()
    {
        Assert.Equal("Bob", this.Name);
    }
}
