using Xunit;

namespace CsharpForFunAndProfitTests;

public class StringLibTests
{
    [Fact]
    public void IntOfOneShouldReturnTextOfOne()
    {
        Assert.Equal("one", StringLib.IntToText(1));
    }
}