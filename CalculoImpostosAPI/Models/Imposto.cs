using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculoImpostosAPI.Models
{
    [Serializable]
    public abstract class Imposto
    {
        public abstract double Calculo(double salario);
    }
}