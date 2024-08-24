using act2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Comisaria comisaria = new Comisaria();

        private void bAsignarPolicia_Click(object sender, EventArgs e)
        {
            DatosPolicia datos = new DatosPolicia();
            if(datos.ShowDialog() == DialogResult.OK )
            {
                bool sePudo;
                string nombre = datos.tbNombre.Text;
                int dni = Convert.ToInt32(datos.tbDni.Text);
                int placa = Convert.ToInt32(datos.tbNro.Text);
                Policia policia = new Policia(dni, placa, nombre);
                sePudo = comisaria.AsignarPolicia(policia);
                if(sePudo)
                {
                    cBagentes.Items.Add(policia.NroPlaca);
                }
                else
                {
                    MessageBox.Show("No se pueden agregar mas agentes");
                }

            }
        }

        private void bAsignarGuardia_Click(object sender, EventArgs e)
        {
            if(cBguardias.SelectedIndex!= -1)
            {
                int nro = Convert.ToInt32(cBagentes.Text);
                int h = Convert.ToInt32(nHora.Text);
                int m = Convert.ToInt32(nMinutos.Text);
                int minutos = Convert.ToInt32(tbMinutos.Text);

                Guardia g = comisaria.AsignarGuardia(nro, h, m, minutos) as Guardia;
                nHora.Text = "0";
                nMinutos.Text = "0";
                tbMinutos.Clear();
                cBguardias.Items.Add($"{nro} ({g.HoraDesde}:{g.MinutoDesde} a {g.HoraHasta}:{g.MinutoHasta})");
            }
            else
            {
                MessageBox.Show("Seleccione el agente");
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipoInc = (comboBox1.SelectedIndex)+1;
            string motivo = tbMotivo.Text;
            Policia agente = comisaria.VerAgente(Convert.ToInt32(cBguardias.Text));
            Persona sujeto = new Persona(tbNombrePers.Text, (Convert.ToInt32(tbDniPer.Text)));
            int h = Convert.ToInt32(nHoraInc.Text);
            int m = Convert.ToInt32(nMinutoInc.Text);
            comisaria.RegistrarIncidente(agente, sujeto, motivo, h, m, tipoInc);
            tbMotivo.Clear();
            tbNombrePers.Clear();
            tbDniPer.Clear();
            nMinutoInc.Text = "0";
            nHoraInc.Text = "0";

        }

        private void bListarInc_Click(object sender, EventArgs e)
        {
            Incidentes incidentes = new Incidentes();
            for(int i = 0; i < comisaria.CantidadIncidentes; i++)
            {
                Incidente inc = comisaria.VerIncidente(i);
                incidentes.tBlista.Text += inc.VerDescripcion();
            }
            incidentes.ShowDialog();
        }

        private void cBguardias_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
