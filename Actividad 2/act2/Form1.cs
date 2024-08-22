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
    }
}
