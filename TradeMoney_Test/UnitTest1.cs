namespace HW1._2_Test;

public class UnitTest1
{
    [Fact]
    public void Test_Cal1000()
    {
        double money = Moneytrade.Cal1000(15249.75);

        Assert.Equal(money, 249.75);
    }
    [Fact]
    public void Test_trade1000()
    {
        double money = Moneytrade.trade1000(15249.75);

        Assert.Equal(money, 15);
    }
    [Fact]
    public void Test_Cal_50()
    {
        double money = Moneytrade.Cal_50(15249.75);

        Assert.Equal(money, 0.25);
    }
    [Fact]
    public void Test_trade_50()
    {
        double money = Moneytrade.trade_50(15249.75);

        Assert.Equal(money, 30499);
    }
    [Fact]
    public void Test_Cal_25()
    {
        double money = Moneytrade.Cal_25(15249.75);

        Assert.Equal(money, 0);
    }
    [Fact]
    public void Test_trade_25()
    {
        double money = Moneytrade.trade_25(15249.75);

        Assert.Equal(money, 60999);
    }
}