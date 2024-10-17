using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario
{
    //menu principal
    internal class Menu
    {
        public static void principal()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1- Inicializar arreglos");
                Console.WriteLine("2- Ingresar articulos");
                Console.WriteLine("3- Modificar Articulos");
                Console.WriteLine("4- Borrar articulos");
                Console.WriteLine("5- Consultar articulos");
                Console.WriteLine("6- Buscar articulo");
                Console.WriteLine("7- Salir");
                Console.WriteLine("Digite una opcion");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: articulos.inicializarArreglos(); break;
                    case 2: articulos.ingresarProductos(); break; 
                    case 3: articulos.modificarProductos(); break;
                    case 4: articulos.excluirProductos(); break;
                    case 5: articulos.consultarProductos(); break;
                    case 6: articulos.buscarArticulos(); break;
                    case 7: Console.WriteLine("Slaiendo del sistema"); break;
                    default: Console.WriteLine("*** opcion incorrecta ***"); break;
                }

            } while (opcion != 7);


        }
    }
}
