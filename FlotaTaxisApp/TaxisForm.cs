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
    public partial class TaxisForm : Form
    {
        public TaxisForm()
        {
            InitializeComponent();
        }

        private void TaxisForm_Load(object sender, EventArgs e)
        {
            this.taxisTableAdapter.Fill(this.flotaTaxisDataSet.Taxis);

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            using (var db = new FlotaTaxisEntities())
            {
                var taxis = db.Taxis.ToList();
                dataGridViewTaxis.DataSource = taxis;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var db = new FlotaTaxisEntities())
            {
                var taxi = new Taxis
                {
                    Modelo = txtModelo.Text
                };
                db.Taxis.Add(taxi);
                db.SaveChanges();
                MessageBox.Show("Taxi agregado correctamente");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (var db = new FlotaTaxisEntities())
            {
                int id = Convert.ToInt32(dataGridViewTaxis.CurrentRow.Cells[0].Value);
                var taxi = db.Taxis.FirstOrDefault(t => t.ID_Taxi == id);
                if (taxi != null)
                {
                    taxi.Modelo = txtModelo.Text;
                    db.SaveChanges();
                    MessageBox.Show("Taxi actualizado correctamente");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var db = new FlotaTaxisEntities())
            {
                int id = Convert.ToInt32(dataGridViewTaxis.CurrentRow.Cells[0].Value);
                var taxi = db.Taxis.FirstOrDefault(t => t.ID_Taxi == id);
                if (taxi != null)
                {
                    db.Taxis.Remove(taxi);
                    db.SaveChanges();
                    MessageBox.Show("Taxi eliminado correctamente");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm menu = new MainForm();

            this.Close();
        }

        private void dataGridViewTaxis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
