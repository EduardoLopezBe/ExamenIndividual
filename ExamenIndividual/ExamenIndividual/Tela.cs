using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    internal class Tela:Productos
    {
        private string nom;
        private string col;
        private string mat;
        private float pre;

        public Tela(string nom, string col, string mat, float pre)
        {
            this.nom = nombre;
            this.col = color;
            this.mat = material;
            this.pre = precio;
        }
        public override string GetDatos()
        {
            return $"el objeto {nom} es de color {col} y está compuesto por {mat}.";
        }

        public override float GetPrecio()
        {
            return pre;
        }
    }
}