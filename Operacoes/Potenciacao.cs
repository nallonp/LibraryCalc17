using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc17.Operacoes
{
    /// <summary>
    /// Realiza o cálculo de potenciação.
    /// </summary>
    public class Potenciacao : IOperacao
    {
        /// <summary>
        /// Retorna um Double que representa A elevado a B.
        /// </summary>
        /// <param name="a">Valor decimal.</param>
        /// <param name="b">Valor decimal.</param>
        /// <returns>Double: resultado.</returns>
        public double Calcula(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
