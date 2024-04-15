using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    internal class Arcilla:Productos
    {
        private string nom;
        private string col;
        private string pes;
        private float pre;

        public Arcilla(string nom, string col, string pes, float pre)
        {
            this.nom = nombre;
            this.col = color;
            this.pes = peso;
            this.pre = precio;
        }
        public override string GetDatos()
        {
            return $"el objeto {nom} es de color {col} y pesa {pes}.";
        }

        public override float GetPrecio()
        {
            return pre;
        }
    }
}