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
        Arcilla arcilla = new Arcilla();


        public string GetDatosArcilla()
        {
            return $"el objeto {arcilla.nom}, de peso {pes}, es de tamaño {tam} y es de color {col}.";
        }
        public string GetDatosTela()
        {
            return $"el objeto {nom}, de tamaño {tam} está compuesto por {mat} y es de color {col}.";
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