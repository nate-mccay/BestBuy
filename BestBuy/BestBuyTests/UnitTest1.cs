using System;
using BestBuy;
using Xunit;


namespace BestBuyTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("noon", true)]
        [InlineData("dog", false)]
        public void IsThisAPalindrome(string word, bool expected)
        {
            var palindromeInstance = new Palindrome();
            var actual = palindromeInstance.IsThisAPalindrome(word);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 6)]
        [InlineData(new int[] { 2, 4, 1 }, 7)]
        [InlineData(new int[] { 1, 4, 3 }, 8)]
        public void CashRegister(int[] num, int expected)
        {
            var CashRegisterInstance = new CashRegister();
            var actual = CashRegisterInstance.CashRegisterSum(num);
            Assert.Equal(expected, actual);
        }
    }
}
