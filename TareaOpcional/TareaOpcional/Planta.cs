using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaOpcional
{
    internal class Planta
    {
        //al cosechar semilla desaparece y da productos
        private string nombre;
        private float tiempoVida;
        private float cantidadFruto;
        private float valorSemilla;
        private float valorFruto;

        public Planta(string nombre, float tiempoVida, float cantidadFruto, float valorSemilla, float valorFruto)
        {
            this.nombre = nombre;
            this.tiempoVida = tiempoVida;
            this.cantidadFruto = cantidadFruto;
            this.valorSemilla = valorSemilla;
            this.valorFruto = valorFruto;
        }
        arcillas.Add(new Arcilla("Maceta", "Gris", "", "Pequena", "Ligera", 5));
        arcillas.Add(new Arcilla("Cacerola", "Azul", "", "Mediana", "Regular", 20));
        public object GetDatos()
        {
            return $"el objeto {nombre}, de tamaño {tiempoVida} está compuesto por {cantidadFruto} y es de color {valorSemilla}   {valorFruto}.";
        }
    }
}
