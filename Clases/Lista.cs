using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Lista
    {
        Nodo primero = null;
        Nodo ant = null;
        public void Agregar(Inventario nuel)
        {
            
            Nodo nuevo = new Nodo();
            nuevo.dato = nuel;
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                            Nodo temp2 = primero;
                            while (temp2.sig != null)
                            {
                                temp2 = temp2.sig;
                            }
                            temp2.sig = nuevo;
            }
            

        }
        public void Mostrar()
        {
            Nodo temp = primero;
            int cont=0;
            while (temp != null)
            {
                cont++;
                
                Console.WriteLine(cont+".");
                Console.WriteLine("Nombre: " + temp.dato.nombre);
                Console.WriteLine("Nombre: " + temp.dato.cantidad);
                temp = temp.sig;
                Console.WriteLine("--------------------------------------");
            }
            
        }
        public void Agregar2(Inventario nuel)
        {
            Nodo temp = primero;
            Nodo nuevo = new Nodo();
            nuevo.dato = nuel;
            while (temp != null)
            {
                if(temp.dato.nombre == nuevo.dato.nombre)
                {
                    nuevo.dato.cantidad+= temp.dato.cantidad;
                    nuevo.dato.contador = temp.dato.contador;
                }
                temp = temp.sig;
            }

            Nodo temp2 = primero;
            Nodo anterior = null;
            while (temp2 != null)
            {
                if (primero.dato.nombre == nuevo.dato.nombre)
                {
                    primero = primero.sig;
                }
                else if (temp2.dato.nombre == nuevo.dato.nombre)
                {
                    anterior.sig = temp2.sig;
                }
                anterior = temp2;
                temp2 = temp2.sig;
            }

        }
        public void Retirar(string elim, int cant)
        {
            int cont = 0;
            Nodo temp = primero;
            while (temp != null)
            {
                if (temp.dato.nombre == elim && temp.dato.cantidad >= cant)
                {
                    cont++;
                    temp.dato.cantidad = temp.dato.cantidad - cant;
                    temp.dato.contador += cant;
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Productos retirados.");
                }
                else if (temp.dato.nombre == elim && temp.dato.cantidad < cant)
                {
                    cont++;
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Cantidad no disponible - Intentelo de nuevo");
                }
                
                temp = temp.sig;
            }
            if(cont == 0)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Producto no encontrado");
            }
        }
        public void Mayor()
        {
            Inventario NV = new Inventario(" ", 0, 0);
            Nodo temp = primero;
            Nodo mayor = new Nodo();
            mayor.dato = NV;
            while (temp != null)
            {
                if (temp.dato.contador >= mayor.dato.contador)
                {
                    mayor = temp;
                }
                temp = temp.sig;
            }
            Console.WriteLine("Mayores ventas: " + mayor.dato.nombre);
            Console.WriteLine("Retiros totales: " + mayor.dato.contador);
        }

    }
}
