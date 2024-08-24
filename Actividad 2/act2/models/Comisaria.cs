using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace act2.models
{
    internal class Comisaria
    {
        Guardia[] guardias = new Guardia[2];
        private ArrayList incidentes = new ArrayList();
        private ArrayList agentes = new ArrayList();
        public int cantGuardias = 0;
        public int CantidadIncidentes
        {
            get
            {
                return incidentes.Count;
            }
        }
        public bool AsignarPolicia(Policia policia)
        {
            if(agentes.Count < 2 )
            {
                agentes.Add( policia );
                return true ;
            }
            else
            {
                return false;
            }
        }
        public Policia VerAgente(int nroPlaca)
        {
            Policia e = null;
            for( int i = 0;i<agentes.Count;i++)
            {
                Policia buscado = agentes[i] as Policia;
                if(buscado.NroPlaca == nroPlaca)
                {
                    e = buscado;
                }

            }
            return e;
        }
        public void RegistrarIncidente(Policia agente, Persona sujeto, string motivo, int h, int m, int tipoIncidente)
        {
            Incidente nuevo = new Incidente(sujeto, agente, motivo, tipoIncidente);
            nuevo.Hora = h;
            nuevo.Minuto = m;
            incidentes.Add(nuevo);
        }
        public Guardia AsignarGuardia(int nro, int h, int m, int cantMinutos)
        {
            cantGuardias++;
            Guardia g = null;
            if (cantGuardias <= 2)
            {
                for( int i = 0; i < agentes.Count; i++)
                {
                    Policia asignado = agentes[i] as Policia;
                    if(asignado.NroPlaca == nro)
                    {
                        Guardia guardia = new Guardia(asignado, h, m, cantMinutos);
                        guardias[cantGuardias - 1] = guardia;
                        g = guardia;
                    }
                }
            }
            return g;
        }
        public Incidente VerIncidente(int nroIncidente)
        {
            Incidente buscado = null;
            for (int i = 0; i < CantidadIncidentes; i++)
            {
                buscado = incidentes[nroIncidente] as Incidente;
            }
            return buscado;
            
        }
    }
}
