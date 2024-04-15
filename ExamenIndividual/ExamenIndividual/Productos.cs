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
        protected string peso;
        protected float precio;
        

        public virtual string GetDatos()
        {
            return "";
        } 

        public virtual float GetPrecio()
        {
            return precio;
        }
    }
}