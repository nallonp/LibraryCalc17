using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc17
{
    /// <summary>
    /// Provê uma interface para operações de uma calculadora.
    /// </summary>
    interface IOperacao
    {
        /// <summary>
        /// Método que calcula a operação.
        /// </summary>
        /// <param name="a">Valor decimal.</param>
        /// <param name="b">Valor decimal.</param>
        /// <returns>Um Double representando o resultado.</returns>
        Double Calcula(Double a, Double b);
    }
}
