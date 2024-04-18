﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIndividual
{
    internal class Tela
    {
        private string nom;
        private string col;
        private string mat;
        private string tam;
        private string pes;
        private float pre;

        public Tela(string nom, string col, string mat, string tam, string pes, float pre)
        {
            this.nom = nom;
            this.col = col;
            this.mat = mat;
            this.tam = tam;
            this.pes = pes;
            this.pre = pre;
        }

        public string GetDatosTela()
        {
            return $"el objeto {nom}, de tamaño {tam} está compuesto por {mat} y es de color {col}.";
        }
        public float GetPrecioTela()
        {
            return pre;
        }
    }
}