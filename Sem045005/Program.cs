using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem045005
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lista ls = new Lista();
            Inventario N1 = new Inventario("Televisión", 10, 0);
            Inventario N2 = new Inventario("Carro", 12,0);
            ls.Agregar(N1);
            ls.Agregar(N2);
            int op = 100;
            do
            {
                Console.Clear();
                Console.WriteLine("------------MENÚ-INVENTARIO------------");
                Console.WriteLine("[1] Mostrar Inventario");
                Console.WriteLine("[2] Agregar producto(s)");
                Console.WriteLine("[3] Retirar producto(s)");
                Console.WriteLine("[4] Producto mas Vendido");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("--------------------------------------");
                Console.Write("Ingresar opción: ");
                
                op=int.Parse(Console.ReadLine());
                
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("---------------IVENTARIO---------------");

                        ls.Mostrar();
                        Console.WriteLine("Presione cualquier tecla para volver.");
                        Console.ReadKey(); break;
                    case 2:
                        Console.WriteLine("----------------AGREGAR---------------");
                        Console.WriteLine("Nombre del producto: ");
                        string nombre = Console.ReadLine(); 
                        Console.WriteLine("Cantidad a ingresar: ");
                        int cant = int.Parse(Console.ReadLine());
                        Inventario NN = new Inventario(nombre, cant,0);
                        ls.Agregar2(NN);
                        ls.Agregar(NN);
                        
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Presione cualquier tecla para volver.");
                        Console.ReadKey(); break;
                    case 3:
                        Console.WriteLine("----------------RETIRAR----------------");
                        Console.Write("Ingresar nombre del producto a retirar: ");
                        string produ = Console.ReadLine();
                        Console.Write("Cantidad a retirar: ");
                        int canti = int.Parse(Console.ReadLine());
                        ls.Retirar(produ,canti);
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Presione cualquier tecla para volver.");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("------------MAYORES-VENTAS------------");
                        ls.Mayor();
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Presione cualquier tecla para volver.");
                        Console.ReadKey();
                        break;
                }
            } while (op != 0);
            Console.WriteLine("Saliendo....");
            Console.ReadKey();

        }
    }
}
