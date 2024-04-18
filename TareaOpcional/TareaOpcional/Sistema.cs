using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaOpcional
{
    internal class Sistema
    {
        /*introducir dinero inicial
        poder comprar semillas y parcelas
        opción para pasar el turno
        al pasar el turno indicar plantas para cosechar
        ver lista de plantas disponibles para cosechar
        al cosechar poder vender los frutos o sembrarlos de nuevo*/
        private List<Planta> plantas;
        float dinero;
        float precioParcela;
        public Sistema()
        {
            plantas = new List<Planta>();
        }
        void Execute()
        {
            Jugar();
            GameLoop();
        }
        private void GameLoop()
        {
            while (dinero >= 0)
            {
                ListaAcciones();
            }
        }
        private void ListaAcciones()
        {
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine("Introduce la acción a realizar: ");
                Console.WriteLine("1. Comprar Parcelas");
                Console.WriteLine("2. Mostrar Semillas");
                Console.WriteLine("3. Comprar Semillas");
                Console.WriteLine("4. Cosechar Frutos");
                Console.WriteLine("5. Pasar Turno");
                Console.WriteLine("6. Salir");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ComprarParcelas(); break;
                    case 2:
                        MostrarSemillas(); break;
                    case 3:
                        ComprarSemillas(); break;
                    case 4:
                        CosecharFrutos(); break;
                    case 5:
                        PasarTurno(); break;
                    case 6:
                        continueFlag = false; break;
                    default:
                        Console.WriteLine("Opción no disponible."); break;
                }
            }
        }
        private void MostrarSemillas()
        {
            bool continueFlag = true;
            while (continueFlag)
            {

                foreach (Planta planta in plantas)
                {
                    Console.WriteLine(planta.GetDatos());
                }
                continueFlag = false;
            }
        }
        private void ComprarParcelas()
        {
            if()
            while (dinero >= 0)
            {
                dinero = dinero - precioParcela;
            }
            precioParcela += 10;
        }
        private void Jugar()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce monto de dinero inicial");
                float dinero = float.Parse(Console.ReadLine());

                if (dinero <= 0)
                {
                    continueFlag = false;
                    Console.WriteLine("Bancarrota.");
                }
                else
                {
                    continueFlag = true;
                }

            }
        }
    }
}