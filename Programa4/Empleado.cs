using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa4
{
    internal class Empleado : Persona
    {
        public Empleado(string nombre, int edad, int sueldo) : base(nombre, edad)
        {
            this.sueldo = sueldo;
        }

        private int sueldo { get; set; }
        public int Sueldo
        {
            get => sueldo;
        }
    }
}
