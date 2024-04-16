using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    internal class Productos
    {
        protected string nombre;
        protected string color;
        protected string material;
        protected string tamanio;
        protected string peso;
        protected float precio;



        public string GetDatosArcilla()
        {
            return $"el objeto {nombre}, de peso {peso}, es de tamaño {tamanio} y es de color {color}.";
        }
        public string GetDatosTela()
        {
            return $"el objeto {nombre}, de tamaño {tamanio} está compuesto por {material} y es de color {color}.";
        }

        public float GetPrecioArcilla()
        {
            return precio;
        }
        public float GetPrecioTela()
        {
            return precio;
        }
    }
}