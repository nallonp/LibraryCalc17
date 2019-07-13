using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LibraryCalc17;

namespace LibraryCalc17Tests
{
    public class SubtracaoTests
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(-1, 2)]
        [InlineData(1, 0)]
        public void SubtracaoSucesso(Double x, Double y)
        {
            var subtracao = new Subtracao();
            Assert.True((x - y) == subtracao.Calcula(x, y));
        }
    }
}
