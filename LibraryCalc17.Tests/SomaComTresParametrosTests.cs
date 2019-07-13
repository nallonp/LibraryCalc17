using LibraryCalc17;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LibraryCalc17Tests
{
    public class SomaComTresParametrosTests
    {
        [Theory]
        [InlineData(1, 2, 4)]
        [InlineData(-1, 2, 6)]
        [InlineData(1, 0, 5)]
        public void SomaComTresParametrosSucesso(int a, int b, int c)
        {
            var s = new SomaComTresParametros();
            Assert.True((a + b + c) == s.Calcula(a, b, c));
        }
    }
}
