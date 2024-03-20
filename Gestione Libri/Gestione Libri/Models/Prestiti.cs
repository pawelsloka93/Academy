using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Libri.Models
{
    internal class Prestiti 
    {
        public Prestiti()
        {
        }

        public int ID { get; set; }

        public string? LibroPrestato { get; set; }

        public  DateTime DataPrestitoOut { get; set; }

        public DateTime DataPrestitoIn { get; set; }
    }
}
