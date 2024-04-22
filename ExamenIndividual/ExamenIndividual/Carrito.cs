using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    internal class Carrito
    {
        private List<Productos> productos = new List<Productos>();

        public void AgregarProducto(Productos p)
        {
            productos.Add(p);
        }

        public float CalculatePrecioTotal()
        {
            float precioTotal = 0;
            foreach (var producto in productos)
            {
                precioTotal += producto.GetPrecio();
            }

            return precioTotal;

        }

        public void MostrarProductos()
        {
            Console.WriteLine("troductos del carrito: ");
            foreach (var producto in productos)
            {
                Console.WriteLine(producto.GetCaracteristicas());
            }

            Console.WriteLine("precio total: " + CalculatePrecioTotal());
        }

    }
}

