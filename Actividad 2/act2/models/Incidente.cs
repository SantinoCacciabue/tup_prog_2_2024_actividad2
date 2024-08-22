using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act2.models
{
    internal class Incidente
    {
        public Persona Sujeto { get; private set; }
        public Policia OficialACargo { get; private set; }
        public string Motivo {  get; set; }
        public int Hora {  get; set; }
        public int Minuto {  get; set; }
        public int TipoIncidente {  get; private set; }
        public Incidente(Persona sujeto, Policia oficialACargo, string motivo, int tipoIncidente)
        {
            Sujeto = sujeto;
            OficialACargo = oficialACargo;
            Motivo = motivo;
            TipoIncidente = tipoIncidente;
        }
        public string VerDescripcion()
        {
            if(TipoIncidente == 0)
            {
                return $"Denuncia policial, emitida a las {Hora}:{Minuto}" +
                    $" Motivo:{Motivo}" +
                    $" Oficial a cargo: {OficialACargo.VerDatos()} " +
                    $"Sujeto denunciante: {Sujeto.VerDatos()}";
            }
            else
            {
                return $"Orden de arresto, emitida a las {Hora}:{Minuto}" +
                    $" Motivo:{Motivo}" +
                    $" Oficial a cargo: {OficialACargo.VerDatos()} " +
                    $"Sujeto a arrestar: {Sujeto.VerDatos()} " +
                    $"Orden: Por la presente se ordena el arresto inmediato de {Sujeto.VerDatos()} El Agente {OficialACargo.VerDatos()} está autorizado a proceder con el arresto conforme a las leyes y regulaciones aplicadas";
            }
        }
    }
}
