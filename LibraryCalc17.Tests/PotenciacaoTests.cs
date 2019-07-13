using LibraryCalc17;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LibraryCalc17Tests
{
    public class PotenciacaoTests
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(-1, 2)]
        [InlineData(1, 0)]
        public void PotenciacaoSucesso(int x, int y)
        {
            var p = new Potenciacao();
            Assert.True(Math.Pow(x,y)==p.Calcula(x,y));
        }
    }
}
