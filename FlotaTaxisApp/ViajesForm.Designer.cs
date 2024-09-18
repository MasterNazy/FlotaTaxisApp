namespace FlotaTaxisApp
{
    partial class ViajesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.flotaTaxisDataSet1 = new FlotaTaxisApp.FlotaTaxisDataSet1();
            this.viajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viajesTableAdapter = new FlotaTaxisApp.FlotaTaxisDataSet1TableAdapters.ViajesTableAdapter();
            this.iDViajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDConductorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPasajeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.cmbConductores = new System.Windows.Forms.ComboBox();
            this.cmbPasajeros = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.viajesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flotaTaxisDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viajesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viajesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDViajeDataGridViewTextBoxColumn,
            this.origenDataGridViewTextBoxColumn,
            this.destinoDataGridViewTextBoxColumn,
            this.iDConductorDataGridViewTextBoxColumn,
            this.iDPasajeroDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.viajesBindingSource1;
            this.dataGridView.Location = new System.Drawing.Point(12, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(546, 249);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // flotaTaxisDataSet1
            // 
            this.flotaTaxisDataSet1.DataSetName = "FlotaTaxisDataSet1";
            this.flotaTaxisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viajesBindingSource
            // 
            this.viajesBindingSource.DataMember = "Viajes";
            this.viajesBindingSource.DataSource = this.flotaTaxisDataSet1;
            // 
            // viajesTableAdapter
            // 
            this.viajesTableAdapter.ClearBeforeFill = true;
            // 
            // iDViajeDataGridViewTextBoxColumn
            // 
            this.iDViajeDataGridViewTextBoxColumn.DataPropertyName = "ID_Viaje";
            this.iDViajeDataGridViewTextBoxColumn.HeaderText = "ID_Viaje";
            this.iDViajeDataGridViewTextBoxColumn.Name = "iDViajeDataGridViewTextBoxColumn";
            this.iDViajeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // origenDataGridViewTextBoxColumn
            // 
            this.origenDataGridViewTextBoxColumn.DataPropertyName = "Origen";
            this.origenDataGridViewTextBoxColumn.HeaderText = "Origen";
            this.origenDataGridViewTextBoxColumn.Name = "origenDataGridViewTextBoxColumn";
            // 
            // destinoDataGridViewTextBoxColumn
            // 
            this.destinoDataGridViewTextBoxColumn.DataPropertyName = "Destino";
            this.destinoDataGridViewTextBoxColumn.HeaderText = "Destino";
            this.destinoDataGridViewTextBoxColumn.Name = "destinoDataGridViewTextBoxColumn";
            // 
            // iDConductorDataGridViewTextBoxColumn
            // 
            this.iDConductorDataGridViewTextBoxColumn.DataPropertyName = "ID_Conductor";
            this.iDConductorDataGridViewTextBoxColumn.HeaderText = "ID_Conductor";
            this.iDConductorDataGridViewTextBoxColumn.Name = "iDConductorDataGridViewTextBoxColumn";
            // 
            // iDPasajeroDataGridViewTextBoxColumn
            // 
            this.iDPasajeroDataGridViewTextBoxColumn.DataPropertyName = "ID_Pasajero";
            this.iDPasajeroDataGridViewTextBoxColumn.HeaderText = "ID_Pasajero";
            this.iDPasajeroDataGridViewTextBoxColumn.Name = "iDPasajeroDataGridViewTextBoxColumn";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(324, 303);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(117, 20);
            this.txtOrigen.TabIndex = 1;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(455, 303);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(103, 20);
            this.txtDestino.TabIndex = 2;
            // 
            // cmbConductores
            // 
            this.cmbConductores.FormattingEnabled = true;
            this.cmbConductores.Location = new System.Drawing.Point(25, 303);
            this.cmbConductores.Name = "cmbConductores";
            this.cmbConductores.Size = new System.Drawing.Size(127, 21);
            this.cmbConductores.TabIndex = 3;
            // 
            // cmbPasajeros
            // 
            this.cmbPasajeros.FormattingEnabled = true;
            this.cmbPasajeros.Location = new System.Drawing.Point(184, 303);
            this.cmbPasajeros.Name = "cmbPasajeros";
            this.cmbPasajeros.Size = new System.Drawing.Size(115, 21);
            this.cmbPasajeros.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(91, 346);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 44);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(184, 344);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(79, 46);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(269, 344);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(82, 46);
            this.btnLeer.TabIndex = 7;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(357, 344);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 46);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Conductores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pasajeros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Origen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Destino";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viajesBindingSource1
            // 
            this.viajesBindingSource1.DataMember = "Viajes";
            this.viajesBindingSource1.DataSource = this.flotaTaxisDataSet1;
            // 
            // ViajesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbPasajeros);
            this.Controls.Add(this.cmbConductores);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.dataGridView);
            this.Name = "ViajesForm";
            this.Text = "ViajesForm";
            this.Load += new System.EventHandler(this.ViajesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flotaTaxisDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viajesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viajesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private FlotaTaxisDataSet1 flotaTaxisDataSet1;
        private System.Windows.Forms.BindingSource viajesBindingSource;
        private FlotaTaxisDataSet1TableAdapters.ViajesTableAdapter viajesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDViajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDConductorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPasajeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.ComboBox cmbConductores;
        private System.Windows.Forms.ComboBox cmbPasajeros;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource viajesBindingSource1;
    }
}