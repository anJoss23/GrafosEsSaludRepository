using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafosEsSalud
{
    public class Nodo
    {
        public string Ciudad { get; set; }

        public Nodo(string ciudad)
        {
            Ciudad = ciudad;
        }
    }
}