using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LibraryCalc17;

namespace LibraryCalc17Tests { 
    public class MultiplicacaoTests
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(-1, 2)]
        [InlineData(1, 0)]
        public void MultiplicacaoSucesso(int x, int y)
        {
            var multiplicacao = new Multiplicacao();
            Assert.True((x * y) == multiplicacao.Calcula(x, y));
        }
    }
}
