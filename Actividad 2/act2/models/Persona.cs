using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act2.models
{
    internal class Persona
    {
        public int DNI { get; private set; }
        public string Nombre { get; private set; }
        public Persona(string nombre, int dni)
        {
            DNI = dni;
            Nombre = nombre;
        }
        public string VerDatos()
        {
            return $"Nombre: {Nombre}--DNI: {DNI}";
        }
    }
}
