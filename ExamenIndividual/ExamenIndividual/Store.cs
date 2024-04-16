using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    internal class Store
    {
        private List<Productos> productos;
        public Store()
        {
            productos = new List<Productos>();
        }
        public void Execute()
        {
            ListaProductos();
        }
        private void ListaProductos()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce el número de la opción:");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Mostrar productos");
                Console.WriteLine("3. Eliminar producto");
                Console.WriteLine("4. Salir");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AgregarProducto();
                        break;
                    case "2":
                        MostrarProductos();
                        break;
                    case "3":
                        EliminarProducto();
                        break;
                    case "4":
                        continueFlag = false;
                        break;
                }
            }
        }
        private void AgregarProducto()
            {
                bool continueFlag = true;
                while (continueFlag)
                {
                    Console.WriteLine("Introduce el número del producto que quieres añadir: ");
                    Console.WriteLine("1. Arcilla");
                    Console.WriteLine("2. Tela");
                    Console.WriteLine("3. Regresar al menú anterior");
                    string option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            AgregarArcilla();
                            continueFlag = false;
                            break;
                        case "2":
                            AgregarTela();
                            continueFlag = false;
                            break;
                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                }
            }
        private void MostrarProductos()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce el tipo del producto que quieres mostrar: ");
                Console.WriteLine("1. Arcilla");
                Console.WriteLine("2. Tela");
                Console.WriteLine("3. Regresar al menú anterior");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        foreach (Productos producto in productos)
                        {
                            Console.WriteLine(producto.GetDatosArcilla());
                        }
                        continueFlag = false;
                        break;
                    case "2":
                        foreach (Productos producto in productos)
                        {
                            Console.WriteLine(producto.GetDatosTela());
                        }
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;

                }
            }
        }
        private void EliminarProducto()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introducir el número del producto a eliminar");
                Console.WriteLine("1. Arcilla");
                Console.WriteLine("2. Tela");
                Console.WriteLine("3. Regresar al menú anterior");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        for (int i = 0; i < productos.Count; i++)
                        {
                            Console.WriteLine($"{i}. {productos[i].GetDatosArcilla()}");
                        }
                        int index = int.Parse(Console.ReadLine());
                        if (index >= 0 && index < productos.Count)
                        {
                            continueFlag = false;
                            productos.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("El producto no existe");
                        }
                        foreach (Productos producto in productos)
                        {
                            Console.WriteLine(producto.GetDatosArcilla());
                        }
                        continueFlag = false;
                        break;
                    case "2":
                        for (int i = 0; i < productos.Count; i++)
                        {
                            Console.WriteLine($"{i}. {productos[i].GetDatosTela()}");
                        }
                        int index = int.Parse(Console.ReadLine());
                        if (index >= 0 && index < productos.Count)
                        {
                            continueFlag = false;
                            productos.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("El producto no existe");
                        }
                        foreach (Productos producto in productos)
                        {
                            Console.WriteLine(producto.GetDatosTela());
                        }
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;

                }
            }
        }

        private void AgregarArcilla()
        {
            
            productos.Add(new Arcilla("Maceta", "Gris","", "Pequena", "Ligera", 5));
            productos.Add(new Arcilla("Cacerola", "Azul", "", "Mediana", "Regular", 20));
            
        }

        private void AgregarTela()
        {
            
            productos.Add(new Tela("Sabana", "Celeste", "Algodón", "Queen", "", 50));
            productos.Add(new Tela("CubreAlmohada", "Amarillo", "Lana", "1.5 plazas", "", 30));
        }
    }
}