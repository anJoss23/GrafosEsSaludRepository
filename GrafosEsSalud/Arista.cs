using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafosEsSalud
{
    public class Arista
    {
        public Nodo Origen { get; set; }
        public Nodo Destino { get; set; }

        public Arista(Nodo origen, Nodo destino)
        {
            Origen = origen;
            Destino = destino;
        }
    }
}