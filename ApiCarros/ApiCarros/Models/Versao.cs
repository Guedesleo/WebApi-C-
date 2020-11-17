using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCarros.Models
{
    public class Versao
    {
        public string marcas { get; set; }

        public int AnoFabricacao { get; set; }

        public int AnoModelo { get; set; }

        public string modelo { get; set; }

        public string versao { get; set; }

        public string codigoFipe { get; set; }
    }
}
