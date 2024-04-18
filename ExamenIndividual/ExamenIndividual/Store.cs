using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    internal class Store
    {
        private List<Arcilla> arcillas;
        private List<Tela> telas;
        public Store()
        {
            arcillas = new List<Arcilla>();
            telas = new List<Tela>();
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
                        foreach (Arcilla arcilla in arcillas)
                        {
                            Console.WriteLine(arcilla.GetDatosArcilla());
                        }
                        continueFlag = false;
                        break;
                    case "2":
                        foreach (Tela tela in telas)
                        {
                            Console.WriteLine(tela.GetDatosTela());
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
                        for (int i = 0; i < arcillas.Count; i++)
                        {
                        Console.WriteLine($"{i}. {arcillas[i].GetDatosArcilla()}");
                        }
                        int index = int.Parse(Console.ReadLine());
                        if (index >= 0 && index < arcillas.Count)
                        {
                            continueFlag = false;
                            arcillas.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("El producto no existe");
                        }
                        continueFlag = false;
                        break;
                    case "2":
                        for (int i = 0; i < telas.Count; i++)
                        {
                            Console.WriteLine($"{i}. {telas[i].GetDatosTela()}");
                        }
                        int inx = int.Parse(Console.ReadLine());
                        if (inx >= 0 && inx < telas.Count - 1)
                        {
                            continueFlag = false;
                            telas.RemoveAt(inx);
                        }
                        else
                        {
                            Console.WriteLine("El producto no existe");
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
            
            arcillas.Add(new Arcilla("Maceta", "Gris","", "Pequena", "Ligera", 5));
            arcillas.Add(new Arcilla("Cacerola", "Azul", "", "Mediana", "Regular", 20));
            
        }

        private void AgregarTela()
        {
            
            telas.Add(new Tela("Sabana", "Celeste", "Algodón", "Queen", "", 50));
            telas.Add(new Tela("CubreAlmohada", "Amarillo", "Lana", "1.5 plazas", "", 30));
        }
    }
}