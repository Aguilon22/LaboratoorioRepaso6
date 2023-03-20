using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoorioRepaso6
{
    public partial class Form1 : Form
    {
        List<Cliente> clientesList = new List<Cliente>();
        List<Vehiculo> vehiculosList = new List<Vehiculo>();
        List<Alquiler> alquieresList = new List<Alquiler>();
        List<Reporte> ReportesList = new List<Reporte>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0; i<alquieresList.Count; i++)
            {
                //Buscar el NIT del alquiler en el NIT Cliente
                for (int j =0; j< clientesList.Count; j++)
                {
                    if (alquieresList[i].Nit == clientesList[j].Nit)
                    {
                        //Guardar los datos en el reporte
                    }
                }
                //Buscar la placa del alquiler en la placa de vheiculo
                for(int k=0; k<vehiculosList.Count; k++)
                {
                    if (alquieresList[i].Placa == vehiculosList[k].Placa)
                    {
                        //Guardar los datos en el reporte
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosVehiculos frm = new DatosVehiculos();
            frm.Show();
        }
    }
}
