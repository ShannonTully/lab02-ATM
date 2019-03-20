using System;
using ConsoleApp1;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void WithdrawValid()
        {
            Assert.Equal(0, Program.Withdraw(10, 10));
        }

        [Fact]
        public void WithdrawInvalid()
        {
            Assert.Equal(10, Program.Withdraw(20, 10));
        }

        [Fact]
        public void AddValid()
        {
            Assert.Equal(20, Program.AddTo(10, 10));
        }

        [Fact]
        public void AddInvalid()
        {
            Assert.Equal(10, Program.AddTo(-10, 10));
        }
    }
}
