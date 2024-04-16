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
        private string mat;
        private string pes;
        private string tam;
        private float pre;

        public Arcilla(string nom, string col, string mat, string tam, string pes, float pre)
        {
            this.nom = nombre;
            this.col = color;
            this.mat = material;
            this.tam = tamanio;
            this.pes = peso;
            this.pre = precio;
        }
        public override string GetDatos()
        {
            return $"el objeto {nom}, de peso {pes}, es de tamaño {tam} y es de color {col}.";
        }

        public override float GetPrecio()
        {
            return pre;
        }
    }
}