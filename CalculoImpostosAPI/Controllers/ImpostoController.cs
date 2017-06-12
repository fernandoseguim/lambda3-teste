using CalculoImpostosAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculoImpostosAPI.Controllers
{
    public class ImpostoDeRendaController : ApiController
    {
        [HttpGet]
        public double Get(double salario)
        {
            return new ImpostoDeRenda().Calculo(salario);
        }
    }
}
