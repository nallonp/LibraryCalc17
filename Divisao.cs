using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc17
{
    /// <summary>
    /// Realiza a operação de divisão entre dois numeros.
    /// </summary>
    public class Divisao : IOperacao
    {
        /// <summary>
        /// Retorna um Double que representa a divisão de A por B ou uma exceção caso houver uma divisão por 0.
        /// </summary>
        /// <param name="a">Valor decimal.</param>
        /// <param name="b">Valor decimal.</param>
        /// <returns>Double: dividendo.</returns>
        public double Calcula(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("O divisor não pode ser 0.");
            else
                return a / b;
        }
    }
}
