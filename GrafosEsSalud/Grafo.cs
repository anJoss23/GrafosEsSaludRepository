using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafosEsSalud
{
    public class Grafo
    {
        private List<Nodo> nodos;
        private List<Arista> aristas;
        private Nodo ubicacionActual;

        public Grafo()
        {
            nodos = new List<Nodo>();
            aristas = new List<Arista>();
        }

        // Agregar un nodo al grafo
        public void AgregarNodo(string ciudad)
        {
            nodos.Add(new Nodo(ciudad));
        }

        // Editar un nodo en el grafo
        public void EditarNodo(string ciudadViejo, string ciudadNuevo)
        {
            Nodo nodo = nodos.FirstOrDefault(n => n.Ciudad == ciudadViejo);
            if (nodo != null)
            {
                nodo.Ciudad = ciudadNuevo;
            }
            else
            {
                Console.WriteLine("Nodo no encontrado.");
            }
        }
        // Listar todos los nodos en el grafo
        public void ListarNodos()
        {
            if (1 == 1)
            {
                Console.WriteLine("Nodos en el grafo:");
            }
            
            foreach (Nodo nodo in nodos)
            {
                Console.WriteLine(nodo.Ciudad);
            }
        }
        // Agregar una arista al grafo
        public void AgregarArista(string ciudadOrigen, string ciudadDestino)
        {
            Nodo nodoOrigen = nodos.FirstOrDefault(n => n.Ciudad == ciudadOrigen);
            Nodo nodoDestino = nodos.FirstOrDefault(n => n.Ciudad == ciudadDestino);

            if (nodoOrigen != null && nodoDestino != null)
            {
                aristas.Add(new Arista(nodoOrigen, nodoDestino));
            }
            else
            {
                Console.WriteLine("Uno o ambos nodos no encontrados.");
            }
        }
        // Establecer la ubicación actual del transporte
        public void EstablecerUbicacion(string ciudad)
        {
            Nodo nodo = nodos.FirstOrDefault(n => n.Ciudad == ciudad);
            if (nodo != null)
            {
                ubicacionActual = nodo;
                Console.WriteLine("Ubicación actual del transporte: " + ubicacionActual.Ciudad);
            }
            else
            {
                Console.WriteLine("Ciudad no encontrada.");
            }
        }
        // Consultar la ubicación actual del transporte
        public void ConsultarUbicacion()
        {
            if (ubicacionActual != null)
            {
                Console.WriteLine("El transporte se encuentra actualmente en: " + ubicacionActual.Ciudad);
            }
            else
            {
                Console.WriteLine("No se ha establecido una ubicación para el transporte.");
            }
        }
        // Mover el transporte a la siguiente ciudad
        public void MoverTransporte(string ciudadDestino)
        {
            Nodo destino = nodos.FirstOrDefault(n => n.Ciudad == ciudadDestino);
            if (ubicacionActual != null && destino != null)
            {
                // Verificar que haya una arista entre la ubicación actual y la ciudad destino
                bool aristaExistente = aristas.Any(a => a.Origen == ubicacionActual && a.Destino == destino);
                if (aristaExistente)
                {
                    ubicacionActual = destino; // Actualizar la ubicación
                    Console.WriteLine("El transporte se ha movido a: " + ubicacionActual.Ciudad);
                }
                else
                {
                    Console.WriteLine("No hay una ruta directa entre las ciudades.");
                }
            }
            else
            {
                Console.WriteLine("La ciudad de destino o la ubicación actual no son válidas.");
            }
        }
    }
}
