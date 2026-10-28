using System;
using System.IO;

namespace parcialprogramacion
{
    class Producto
    {
        private int idProducto;
        private string nombreProducto;
        public string Precio{get;set;}
        
    public Producto(int nro, string nombre, string precio="100")
    {
        idProducto = nro;
        nombreProducto = nombre;
        Precio=precio;
    }
    public string ObtenerDatos()
    {
        return $"{idProducto};{nombreProducto};{Precio}";
    }
    public void Mostrar()
    {
        Console.WriteLine($"Id: {idProducto}, Nombre:{nombreProducto}, Precio: {Precio}");
    }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Producto[] catalogo = new Producto[5];

            catalogo[0] = new Producto(1, "Heladera SIAM", "800");
            catalogo[1] = new Producto(2, "Lavarropas DREAN", "400");
            catalogo[2] = new Producto(3, "Televisor PHILCO", "300");
            catalogo[3] = new Producto(4, "Plancha ATMA", "200");
            catalogo[4] = new Producto(5, "Ventilador LILIANA", "300");
            int opcion;
            do{
                Console.WriteLine("1) Cargar desde archivo y mostrar catálogo actual");
                Console.WriteLine("2) Duplicar el precio de los productos");
                Console.WriteLine("3) Guardar en archivo el catálogo actual");
                Console.WriteLine("4) Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                    for(int i=0; i < catalogo.Length; i++)
                    {
                        catalogo[i].Mostrar();
                    }
                    break;
                    case 2:
                    for(int i=0; i < catalogo.Length; i++)
                    {
                        catalogo[i].Precio = (Convert.ToInt32(catalogo[i].Precio) * 2).ToString();
                    }
                    for(int i=0; i < catalogo.Length; i++)
                    {
                        catalogo[i].Mostrar();
                    }
                    break;
                    case 3:
                    string contenido ="";
                    for(int i=0; i < catalogo.Length; i++)
                    {
                        contenido+= catalogo[i].ObtenerDatos()+ "\n";
                    }
                    File.WriteAllText(@"c:\temp\catalogo.txt",contenido);
                    Console.WriteLine("Archivo Guardado");
                    break;
                    case 4:
                    Console.WriteLine("Chau chau");
                    break;
                    default:
                    Console.WriteLine("Opción no válida");
                    break;
                }
            }while(opcion!=4);
            Console.WriteLine("Programa finalizado");
        }
    }
}
