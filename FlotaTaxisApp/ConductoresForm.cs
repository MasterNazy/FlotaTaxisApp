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
    public partial class ConductoresForm : Form
    {
        public ConductoresForm()
        {
            InitializeComponent();
        }

        private void ConductoresForm_Load(object sender, EventArgs e)
        {
            this.conductoresTableAdapter.Fill(this.flotaTaxisDataSet1.Conductores);
            CargarTaxis();  
            btnLeer_Click(null, null);  

        }

        private void CargarTaxis()
        {
            using (var db = new FlotaTaxisEntities())
            {
                var taxis = db.Taxis.Select(t => new { t.ID_Taxi, t.Modelo }).ToList();
                cmbTaxis.DataSource = taxis;
                cmbTaxis.DisplayMember = "Modelo";
                cmbTaxis.ValueMember = "ID_Taxi";
            }
        }

        private void dataGridViewConductores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            using (var db = new FlotaTaxisEntities())
            {
                var conductores = db.Conductores.Include("Taxis").ToList();
                dataGridViewConductores.DataSource = conductores.Select(c => new {
                    c.ID_Conductor,
                    c.Nombre,
                    c.ID_Taxi,  // Mostrar el ID del taxi
                    Taxi = c.Taxis.Modelo  // Mostrar el modelo del taxi
                }).ToList();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var db = new FlotaTaxisEntities())
            {
                var conductor = new Conductores
                {
                    Nombre = txtNombreConductor.Text,
                    ID_Taxi = Convert.ToInt32(cmbTaxis.SelectedValue)  // Asignar el taxi seleccionado
                };
                db.Conductores.Add(conductor);
                db.SaveChanges();
                MessageBox.Show("Conductor agregado correctamente");
                btnLeer_Click(null, null);  // Recargar la lista de conductores
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (var db = new FlotaTaxisEntities())
            {
                int id = Convert.ToInt32(dataGridViewConductores.CurrentRow.Cells[0].Value);
                var conductor = db.Conductores.FirstOrDefault(c => c.ID_Conductor == id);
                if (conductor != null)
                {
                    conductor.Nombre = txtNombreConductor.Text;
                    conductor.ID_Taxi = Convert.ToInt32(cmbTaxis.SelectedValue);  // Actualizar taxi asignado
                    db.SaveChanges();
                    MessageBox.Show("Conductor actualizado correctamente");
                    btnLeer_Click(null, null);  // Recargar la lista
                }
            }
        }

        private void cmbTaxis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm menu = new MainForm();

            this.Close();
        }
    }
}
