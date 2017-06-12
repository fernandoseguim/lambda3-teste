using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculoImpostosAPI.Models
{
    [Serializable]
    public class ImpostoDeRenda : Imposto
    {
        public override double Calculo(double salario)
        {
            if (salario > 4664.68)
            {
                return 869.36;
            }
            else if (salario > 3751.05)
            {
                return 636.13;
            }
            else if (salario > 2826.65)
            {
                return 345.80;
            }
            else if (salario > 1903.98)
            {
                return 142.80;
            }
            return 0.0;
        }
    }
}