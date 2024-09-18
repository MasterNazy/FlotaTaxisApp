namespace FlotaTaxisApp
{
    partial class ConductoresForm
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
            this.dataGridViewConductores = new System.Windows.Forms.DataGridView();
            this.flotaTaxisDataSet = new FlotaTaxisApp.FlotaTaxisDataSet();
            this.flotaTaxisDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flotaTaxisDataSet1 = new FlotaTaxisApp.FlotaTaxisDataSet1();
            this.conductoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conductoresTableAdapter = new FlotaTaxisApp.FlotaTaxisDataSet1TableAdapters.ConductoresTableAdapter();
            this.iDConductorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTaxiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreConductor = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.cmbTaxis = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConductores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flotaTaxisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flotaTaxisDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flotaTaxisDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewConductores
            // 
            this.dataGridViewConductores.AutoGenerateColumns = false;
            this.dataGridViewConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConductores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDConductorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.iDTaxiDataGridViewTextBoxColumn});
            this.dataGridViewConductores.DataSource = this.conductoresBindingSource;
            this.dataGridViewConductores.Location = new System.Drawing.Point(16, 14);
            this.dataGridViewConductores.Name = "dataGridViewConductores";
            this.dataGridViewConductores.Size = new System.Drawing.Size(346, 408);
            this.dataGridViewConductores.TabIndex = 0;
            this.dataGridViewConductores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConductores_CellContentClick);
            // 
            // flotaTaxisDataSet
            // 
            this.flotaTaxisDataSet.DataSetName = "FlotaTaxisDataSet";
            this.flotaTaxisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flotaTaxisDataSetBindingSource
            // 
            this.flotaTaxisDataSetBindingSource.DataSource = this.flotaTaxisDataSet;
            this.flotaTaxisDataSetBindingSource.Position = 0;
            // 
            // flotaTaxisDataSet1
            // 
            this.flotaTaxisDataSet1.DataSetName = "FlotaTaxisDataSet1";
            this.flotaTaxisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conductoresBindingSource
            // 
            this.conductoresBindingSource.DataMember = "Conductores";
            this.conductoresBindingSource.DataSource = this.flotaTaxisDataSet1;
            // 
            // conductoresTableAdapter
            // 
            this.conductoresTableAdapter.ClearBeforeFill = true;
            // 
            // iDConductorDataGridViewTextBoxColumn
            // 
            this.iDConductorDataGridViewTextBoxColumn.DataPropertyName = "ID_Conductor";
            this.iDConductorDataGridViewTextBoxColumn.HeaderText = "ID_Conductor";
            this.iDConductorDataGridViewTextBoxColumn.Name = "iDConductorDataGridViewTextBoxColumn";
            this.iDConductorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // iDTaxiDataGridViewTextBoxColumn
            // 
            this.iDTaxiDataGridViewTextBoxColumn.DataPropertyName = "ID_Taxi";
            this.iDTaxiDataGridViewTextBoxColumn.HeaderText = "ID_Taxi";
            this.iDTaxiDataGridViewTextBoxColumn.Name = "iDTaxiDataGridViewTextBoxColumn";
            // 
            // txtNombreConductor
            // 
            this.txtNombreConductor.Location = new System.Drawing.Point(619, 87);
            this.txtNombreConductor.Name = "txtNombreConductor";
            this.txtNombreConductor.Size = new System.Drawing.Size(164, 20);
            this.txtNombreConductor.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(400, 128);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 44);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(495, 127);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(99, 45);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(600, 127);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 45);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(707, 128);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(87, 44);
            this.btnLeer.TabIndex = 5;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // cmbTaxis
            // 
            this.cmbTaxis.FormattingEnabled = true;
            this.cmbTaxis.Location = new System.Drawing.Point(400, 87);
            this.cmbTaxis.Name = "cmbTaxis";
            this.cmbTaxis.Size = new System.Drawing.Size(181, 21);
            this.cmbTaxis.TabIndex = 6;
            this.cmbTaxis.SelectedIndexChanged += new System.EventHandler(this.cmbTaxis_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione el modelo del Taxi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre del Conductor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConductoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTaxis);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreConductor);
            this.Controls.Add(this.dataGridViewConductores);
            this.Name = "ConductoresForm";
            this.Text = "ConductoresForm";
            this.Load += new System.EventHandler(this.ConductoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConductores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flotaTaxisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flotaTaxisDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flotaTaxisDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewConductores;
        private System.Windows.Forms.BindingSource flotaTaxisDataSetBindingSource;
        private FlotaTaxisDataSet flotaTaxisDataSet;
        private FlotaTaxisDataSet1 flotaTaxisDataSet1;
        private System.Windows.Forms.BindingSource conductoresBindingSource;
        private FlotaTaxisDataSet1TableAdapters.ConductoresTableAdapter conductoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDConductorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTaxiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtNombreConductor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.ComboBox cmbTaxis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}