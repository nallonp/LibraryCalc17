using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LibraryCalc17;

namespace LibraryCalc17Tests
{
    public class DivisaoTests
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(-1, 2)]
        [InlineData(1, 0)]
        public void DivisaoSucesso(Double x, Double y)
        {
            var divisao = new Divisao();
            if (y != 0)
                Assert.True((x / y) == divisao.Calcula(x, y));
            else
            {
                var ex = Assert.Throws<ArgumentException>(() => divisao.Calcula(x,0));
                Assert.Equal("O divisor não pode ser 0.", ex.Message);
            }
        }
    }
}
