using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa4
{
    internal class Persona : Iimpresora
    {
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        private string nombre { get; set; } = null!;
        private int edad {  get; set; }
        public string Nombre
        {
            get => nombre;
        }
        public int Edad
        {
            get => edad;
        }

        public void Imprimir(string value)
        {
            Console.WriteLine(value);
        }
    }
}
