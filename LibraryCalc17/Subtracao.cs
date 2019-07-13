using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc17
{
    /// <summary>
    /// Realiza a operação de subtração entre dois numeros.
    /// </summary>
    public class Subtracao : IOperacao
    {
        /// <summary>
        /// Retorna um Double que representa a subtração de A por B.
        /// </summary>
        /// <param name="a">Valor decimal.</param>
        /// <param name="b">Valor decimal.</param>
        /// <returns>Double: resultado.</returns>
        public double Calcula(double a, double b)
        {
            return a - b;
        }
    }
}
