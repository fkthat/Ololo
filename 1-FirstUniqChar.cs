using Xunit;

namespace MidInterviewTest;

/*
    Given a string s, 
    find the first non-repeating character in it and return its index. 
    If it does not exist, return -1.
*/
public static class Finder {
    public static int FirstUniqChar(string s) {
        throw new NotImplementedException();
    }
}


public class TestFinder {
    [Theory]
    [InlineData("works", 0)]
    [InlineData("soundscool", 2)]
    [InlineData("zzbb", -1)]
    public void Test(string s, int expected) {
        var actual = Finder.FirstUniqChar(s);
        Assert.Equal(expected, actual);
    }
}