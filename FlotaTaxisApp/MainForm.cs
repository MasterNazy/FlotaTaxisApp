using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlotaTaxisApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void taxisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaxisForm taxisForm = new TaxisForm();
            taxisForm.Show();
        }

        private void conductoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConductoresForm conductoresForm = new ConductoresForm();
            conductoresForm.Show();
        }

        private void ViajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViajesForm viajesForm = new ViajesForm();
            viajesForm.Show();
        }

        private void pasajerosToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            PasajerosForm pasajerosForm = new PasajerosForm();
            pasajerosForm.Show();
        }
    }
}
