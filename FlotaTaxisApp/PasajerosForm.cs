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
    public partial class PasajerosForm : Form
    {
        public PasajerosForm()
        {
            InitializeComponent();
        }

        private void PasajerosForm_Load(object sender, EventArgs e)
        {
            btnLeer_Click(null, null);
            this.pasajerosTableAdapter.Fill(this.flotaTaxisDataSet1.Pasajeros);

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            using (var db = new FlotaTaxisEntities())
            {
                var pasajeros = db.Pasajeros.ToList();
                dataGridView.DataSource = pasajeros.Select(p => new {
                    p.ID_Pasajero,
                    p.Nombre
                }).ToList();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var db = new FlotaTaxisEntities())
            {
                var pasajero = new Pasajeros
                {
                    Nombre = txtNombre.Text
                };
                db.Pasajeros.Add(pasajero);
                db.SaveChanges();
                MessageBox.Show("Pasajero agregado correctamente");
                btnLeer_Click(null, null);  
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (var db = new FlotaTaxisEntities())
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
                var pasajero = db.Pasajeros.FirstOrDefault(p => p.ID_Pasajero == id);
                if (pasajero != null)
                {
                    pasajero.Nombre = txtNombre.Text;
                    db.SaveChanges();
                    MessageBox.Show("Pasajero actualizado correctamente");
                    btnLeer_Click(null, null);  
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var db = new FlotaTaxisEntities())
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);  
                var pasajero = db.Pasajeros.FirstOrDefault(p => p.ID_Pasajero == id);  
                if (pasajero != null)
                {
                    db.Pasajeros.Remove(pasajero);  
                    db.SaveChanges();
                    MessageBox.Show("Pasajero eliminado correctamente");
                    btnLeer_Click(null, null);  
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el pasajero para eliminar.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm menu = new MainForm();

            this.Close();
        }
    }
}
