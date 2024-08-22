using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act2.models
{
    internal class Policia
    {
        public int DNI { get; private set; }
        public string Nombre { get; private set; }
        public int NroPlaca {  get; private set; }
        public Policia(int dni, int nroPlaca, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
            NroPlaca = nroPlaca;
        }
        public string VerDatos()
        {
            return $"Nombre: {Nombre}--DNI: {DNI}--Numero de placa: {NroPlaca}";
        }
    }
}
