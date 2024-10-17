using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario
{

    internal class articulos
    {
        public static int[] id = new int[3]; //codigo del articulo
        public static string[]nombre = new string[3]; //nombre del articulo
        public static int[] precio = new int[3]; //precio del articulo
        public static int[] cantidad = new int[3]; //cantidad del articulo
        public static string[] bodega = new string[3]; //bodega donde se guardara el articulo

        //metodo para inicializar arreglos
        public static void inicializarArreglos() 
        {
            for (int i = 0; i < id.Length; i++) {
                id[i] = 0;
                nombre[i] = "";
                precio[i] = 0;
                cantidad[i] = 0;
                bodega[i] = "";
               
            }
            Console.WriteLine("Los arreglos han sido inicializados");
            Console.Clear();


        }
        //metodo para ingresar articulos
        public static void ingresarProductos() 
        {
            Console.Clear();
            int indice = 0;
            while (indice<id.Length)
            {
                Console.WriteLine("Digite un codigo: ");
                id[indice] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite un articulo: ");
                nombre[indice] = Console.ReadLine();
                Console.WriteLine("Digite un precio: ");
                precio[indice] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite la cantidad: ");
                cantidad[indice] = int.Parse(Console.ReadLine());
                Console.WriteLine("En que bodega se guardara: ");
                bodega[indice] = Console.ReadLine();
                indice++;
                Console.Clear();
            }
            Console.WriteLine("Los articulos han sido ingresados"); 
        
        }
        //meotodo pra modificar productos
        public static void modificarProductos() 
        {
            Console.Clear();
            Console.WriteLine("Digite el codigo que desea modificar: ");
            int nuevocodigo = int.Parse(Console.ReadLine());
            for (int i = 0; i < id.Length; i++)
            {
                if (nuevocodigo == id[i]) 
                {
                    Console.WriteLine($"Codigo: {id[i]} Nombre: {nombre[i]}");
                    Console.Write("Digite un nuevo nombre: ");
                    nombre[i] = Console.ReadLine();
                    Console.Write("Digite un nuevo precio: ");
                    precio[i] = int.Parse(Console.ReadLine());
                    Console.Write("Digite su cantidad: ");
                    cantidad[i] = int.Parse(Console.ReadLine());
                    Console.Write("en que bodega se albergara: ");
                    bodega[i] = Console.ReadLine();
                    break;

                }
            }
        }
        //meotdo para consultar productos
        public static void consultarProductos() 
        {
            Console.Clear();
            Console.WriteLine("*** Reporte de articulos ***");
            for (int i = 0; i < id.Length; i++)
            {
                Console.WriteLine($"Codigo: {id[i]} Nombre: {nombre[i]} precio: { precio[i]} cantidad: {cantidad[i]} bodega: {bodega[i]}");
            }
            Console.WriteLine("*** FIN DEL REPORTE ***");
        }
        //metodo para eliminar articulos
        public static void excluirProductos() 
        {
            Console.Clear();
            Console.WriteLine("Digite el código del artículo que desea eliminar: ");
            int codigoEliminar = int.Parse(Console.ReadLine());

            bool encontrado = false;
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == codigoEliminar)
                {
                    Console.WriteLine($"Artículo encontrado: Código: {id[i]}, Nombre: {nombre[i]}");
                    Console.WriteLine("¿Está seguro que desea eliminar este artículo? (s/n)");
                    string confirmacion = Console.ReadLine();

                    if (confirmacion.ToLower() == "s")
                    {
                        // Eliminar el artículo
                        id[i] = 0;  // O cualquier valor que indique que está vacío
                        nombre[i] = ""; // Eliminar el nombre

                        Console.WriteLine("El artículo ha sido eliminado.");
                    }
                    else
                    {
                        Console.WriteLine("Operación cancelada.");
                    }
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró un artículo con ese código.");
            }
        }
        public static void buscarArticulos() 
        {
            Console.Clear();
            Console.WriteLine("Digite el código del artículo que desea consultar: ");
            int articuloseleccionado = int.Parse(Console.ReadLine());
            for (int i = 0; i < id.Length; i++)
            {
                if (articuloseleccionado == id[i])
                {
                    Console.WriteLine($"Codigo: {id[i]} Nombre: {nombre[i]} precio: {precio[i]} cantidad: {cantidad[i]} bodega: {bodega[i]}");
                    break;

                }
                Console.WriteLine("*** DETALLES DEL ARTICULO SELECCIONADO ***");
            }
        }
    }

    }


