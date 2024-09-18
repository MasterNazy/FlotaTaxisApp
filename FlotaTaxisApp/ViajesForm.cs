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
    public partial class ViajesForm : Form
    {
        public ViajesForm()
        {
            InitializeComponent();
        }

        private void ViajesForm_Load(object sender, EventArgs e)
        {
            CargarConductores();  
            CargarPasajeros();  
            btnLeer_Click(null, null);
            this.viajesTableAdapter.Fill(this.flotaTaxisDataSet1.Viajes);

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            using (var db = new FlotaTaxisEntities())
            {
                var viajes = db.Viajes.Include("Conductores").Include("Pasajeros").ToList();
                dataGridView.DataSource = viajes.Select(v => new {
                    v.ID_Viaje,
                    v.Origen,
                    v.Destino,
                    v.ID_Conductor,  
                    Conductor = v.Conductores.Nombre,  
                    v.ID_Pasajero,  
                    Pasajero = v.Pasajeros.Nombre  
                }).ToList();
            }
           
        }
        private void CargarConductores()
        {
            using (var db = new FlotaTaxisEntities())
            {
                var conductores = db.Conductores.Select(c => new { c.ID_Conductor, c.Nombre }).ToList();
                cmbConductores.DataSource = conductores;
                cmbConductores.DisplayMember = "Nombre";
                cmbConductores.ValueMember = "ID_Conductor";
            }
        }
        private void CargarPasajeros()
        {
            using (var db = new FlotaTaxisEntities())
            {
                var pasajeros = db.Pasajeros.Select(p => new { p.ID_Pasajero, p.Nombre }).ToList();
                cmbPasajeros.DataSource = pasajeros;
                cmbPasajeros.DisplayMember = "Nombre";
                cmbPasajeros.ValueMember = "ID_Pasajero";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var db = new FlotaTaxisEntities())
            {
                var viaje = new Viajes
                {
                    Origen = txtOrigen.Text,
                    Destino = txtDestino.Text,
                    ID_Conductor = Convert.ToInt32(cmbConductores.SelectedValue),  
                    ID_Pasajero = Convert.ToInt32(cmbPasajeros.SelectedValue) 
                };
                db.Viajes.Add(viaje);
                db.SaveChanges();
                MessageBox.Show("Viaje agregado correctamente");
                btnLeer_Click(null, null);  
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (var db = new FlotaTaxisEntities())
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
                var viaje = db.Viajes.FirstOrDefault(v => v.ID_Viaje == id);
                if (viaje != null)
                {
                    viaje.Origen = txtOrigen.Text;
                    viaje.Destino = txtDestino.Text;
                    viaje.ID_Conductor = Convert.ToInt32(cmbConductores.SelectedValue);  
                    viaje.ID_Pasajero = Convert.ToInt32(cmbPasajeros.SelectedValue);  
                    db.SaveChanges();
                    MessageBox.Show("Viaje actualizado correctamente");
                    btnLeer_Click(null, null);  
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var db = new FlotaTaxisEntities())
            {
                {
                    int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);  
                    var viaje = db.Viajes.FirstOrDefault(v => v.ID_Viaje == id);  
                    if (viaje != null)
                    {
                        db.Viajes.Remove(viaje);  
                        db.SaveChanges();
                        MessageBox.Show("Viaje eliminado correctamente");
                        btnLeer_Click(null, null);  
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm menu = new MainForm();

            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
