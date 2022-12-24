using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoEstacionamento.Models
{
    public class Veiculo
    {
        public decimal valorInicial { get; set; }
        public decimal valorPorHora { get; set; }
        public string placa { get; set; }
    }
}