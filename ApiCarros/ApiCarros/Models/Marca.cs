using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCarros.Models
{
    public class Marca
    {
        public int id { get; set; }

        public string nome{ get; set; }

        public string codigo { get; set; }
    }
}
