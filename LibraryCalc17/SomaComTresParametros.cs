using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc17 { 
    /// <summary>
    /// Realiza a operação de soma entre três numeros.
    /// </summary>
    public class SomaComTresParametros
    {
        /// <summary>
        /// Retorna um Double que representa a soma de três termos.
        /// </summary>
        /// <param name="a">Valor decimal.</param>
        /// <param name="b">Valor decimal.</param>
        /// <param name="c">Valor decimal.</param>
        /// <returns>Double: resultado.</returns>
        public double Calcula(Double a, Double b, Double c)
        {
            return a + b + c;
        }
    }
}
