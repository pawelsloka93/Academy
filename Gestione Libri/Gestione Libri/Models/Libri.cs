using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Libri.Models
{
    internal class Libri 
    {
        public int  ID { get; set; }

        public string? Titolo { get; set; }

        public int Anno { get; set;}

        public bool IsDisponibile { get; set; }
    }
}
