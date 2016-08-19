using FeelingLucky.Tests.Targets;
using System;
using Xunit;

namespace FeelingLucky.Tests
{
    public class Tests
    {
        [Fact]
        public void TestBasicInvocation() 
        {
            var target = new BasicMethod();
            Assert.Equal(1, target.One());

            Assert.Equal(1, target.Lucky());
            Assert.Equal(1, target.Lucky<BasicMethod, int>());
        }
    }
}
