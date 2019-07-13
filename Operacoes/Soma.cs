using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc17.Operacoes
{
    /// <summary>
    /// Realiza a soma de dois numeros.
    /// </summary>
    public class Soma : IOperacao
    {
        /// <summary>
        /// Retorna um Double que representa a soma de A e B.
        /// </summary>
        /// <param name="a">Valor decimal.</param>
        /// <param name="b">Valor decimal.</param>
        /// <returns>Double: resultado.</returns>
        public double Calcula(double a, double b)
        {
            return a + b;
        }
    }
}