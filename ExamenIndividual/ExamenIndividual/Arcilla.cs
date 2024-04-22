using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    internal class Arcilla:Productos
    {
        public float Peso { get; set; }

        public override string GetCaracteristicas()
        {
            return "Nombre: " + Nombre + "Peso: " + "Color: " + Color + "Precio: " + Precio;
        }
    }
}