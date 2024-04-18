using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    internal class Arcilla
    {
        private string nom;
        private string col;
        private string mat;
        private string pes;
        private string tam;
        private float pre;

        public Arcilla(string nom, string col, string mat, string tam, string pes, float pre)
        {
            this.nom = nom;
            this.col = col;
            this.mat = mat;
            this.tam = tam;
            this.pes = pes;
            this.pre = pre;
        }
        public string GetDatosArcilla()
        {
            return $"el objeto {nom}, de peso {pes}, es de tamaño {tam} y es de color {col}.";
        }

        public float GetPrecioArcilla()
        {
            return pre;
        }
    }
}