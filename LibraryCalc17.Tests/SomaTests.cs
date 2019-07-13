using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LibraryCalc17;

namespace LibraryCalc17Tests
{
    public class SomaTests
    {
        [Theory]
        [InlineData(1,2)]
        [InlineData(-1,2)]
        [InlineData(1,0)]
        public void SomaSucesso(int x, int y)
        {
            var soma = new Soma();
            Assert.True((x + y) == soma.Calcula(x, y));
        }
    }
}
