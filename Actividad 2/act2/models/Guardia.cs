using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act2.models
{
    internal class Guardia
    {
        public  Policia OficialAsignado{get; private set;}
        public int HoraDesde { get;  set;}
        public int MinutoDesde {  get;  set;}
        public int CantidadMinutos {  get;  set;}
        public int HoraHasta
        {
            get
            {
                return ((HoraDesde*60)+(CantidadMinutos))/60;
            }
        }
        public int MinutoHasta
        {
            get
            {
                return (MinutoDesde+CantidadMinutos) % 60;
            }
        }
        public Guardia(Policia policia, int h, int m, int cantMin)
        {
            OficialAsignado = policia;
            HoraDesde = h;
            MinutoDesde = m;
            CantidadMinutos = cantMin;
        }
    }
}
