using GrafosEsSalud;

class Program
{
    static void Main(string[] args)
    {
        Grafo miGrafo = new Grafo();
        miGrafo.AgregarNodo("Lima");
        miGrafo.AgregarNodo("Huaraz");
        miGrafo.AgregarNodo("Trujillo");

        // Listar los nodos
        miGrafo.ListarNodos();

        // Crear conexiones entre nodos (ciudades)
        miGrafo.AgregarArista("Lima", "Huaraz");
        miGrafo.AgregarArista("Huaraz", "Trujillo");

        // Establecer la ubicación inicial y consultar
        miGrafo.EstablecerUbicacion("Lima");
        miGrafo.ConsultarUbicacion();
        miGrafo.MoverTransporte("Huaraz");
        miGrafo.ConsultarUbicacion();
        miGrafo.MoverTransporte("Trujillo");
        miGrafo.ConsultarUbicacion();

        // Editar un nodo (ciudad)
        miGrafo.EditarNodo("Huaraz", "Huanuco");
        Console.WriteLine("\nDespués de editar un nodo:");
        miGrafo.ListarNodos();

        // Crear conexiones entre nodos (ciudades)
        miGrafo.AgregarArista("Lima", "Huanuco");
        miGrafo.AgregarArista("Huanuco", "Trujillo");

        // Establecer la ubicación inicial y consultar
        miGrafo.EstablecerUbicacion("Lima");
        miGrafo.ConsultarUbicacion();
        miGrafo.MoverTransporte("Huanuco");
        miGrafo.ConsultarUbicacion();
        miGrafo.MoverTransporte("Trujillo");
        miGrafo.ConsultarUbicacion();
    }
}