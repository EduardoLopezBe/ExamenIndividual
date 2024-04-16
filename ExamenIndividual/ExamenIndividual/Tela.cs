using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    internal class Tela : Productos
    {
        private string nom;
        private string col;
        private string mat;
        private string tam;
        private string pes;
        private float pre;

        public Tela(string nom, string col, string mat, string tam, string pes, float pre)
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
            return $"el objeto {nom}, de tamaño {tam} está compuesto por {mat} y es de color {col}.";
        }
        public override float GetPrecio()
        {
            return pre;
        }
    }
}