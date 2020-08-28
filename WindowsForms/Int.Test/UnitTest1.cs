using System;
using Xunit;

namespace Int.Test
{
    public class UnitTest1
    {
        [Fact]
        public void SimpleIntrestTest()
        {
            string si = WindowsFormsApp2.Maths.simpleInterest(1, 2, 3);
            Assert.Equal("6", si);
        }

        [Fact]
        public void CompoundIntrestTest()
        {
            string si = WindowsFormsApp2.Maths.compoundInterest(1, 2, 3);
            Assert.Equal("27", si);
        }
    }
}
