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
    public partial class DatosVehiculos : Form
    {
        public DatosVehiculos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
