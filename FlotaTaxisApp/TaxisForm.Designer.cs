namespace FlotaTaxisApp
{
    partial class TaxisForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewTaxis = new System.Windows.Forms.DataGridView();
            this.flotaTaxisDataSet = new FlotaTaxisApp.FlotaTaxisDataSet();
            this.taxisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxisTableAdapter = new FlotaTaxisApp.FlotaTaxisDataSetTableAdapters.TaxisTableAdapter();
            this.iDTaxiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flotaTaxisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTaxis
            // 
            this.dataGridViewTaxis.AutoGenerateColumns = false;
            this.dataGridViewTaxis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaxis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTaxiDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn});
            this.dataGridViewTaxis.DataSource = this.taxisBindingSource;
            this.dataGridViewTaxis.Location = new System.Drawing.Point(33, 26);
            this.dataGridViewTaxis.Name = "dataGridViewTaxis";
            this.dataGridViewTaxis.Size = new System.Drawing.Size(248, 412);
            this.dataGridViewTaxis.TabIndex = 0;
            this.dataGridViewTaxis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTaxis_CellContentClick);
            // 
            // flotaTaxisDataSet
            // 
            this.flotaTaxisDataSet.DataSetName = "FlotaTaxisDataSet";
            this.flotaTaxisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taxisBindingSource
            // 
            this.taxisBindingSource.DataMember = "Taxis";
            this.taxisBindingSource.DataSource = this.flotaTaxisDataSet;
            // 
            // taxisTableAdapter
            // 
            this.taxisTableAdapter.ClearBeforeFill = true;
            // 
            // iDTaxiDataGridViewTextBoxColumn
            // 
            this.iDTaxiDataGridViewTextBoxColumn.DataPropertyName = "ID_Taxi";
            this.iDTaxiDataGridViewTextBoxColumn.HeaderText = "ID_Taxi";
            this.iDTaxiDataGridViewTextBoxColumn.Name = "iDTaxiDataGridViewTextBoxColumn";
            this.iDTaxiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(311, 119);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(76, 37);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(400, 119);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(67, 37);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(482, 119);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(77, 37);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(574, 119);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(72, 37);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(379, 78);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(130, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Modelo del Taxi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TaxisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridViewTaxis);
            this.Name = "TaxisForm";
            this.Text = "TaxisForm";
            this.Load += new System.EventHandler(this.TaxisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flotaTaxisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTaxis;
        private FlotaTaxisDataSet flotaTaxisDataSet;
        private System.Windows.Forms.BindingSource taxisBindingSource;
        private FlotaTaxisDataSetTableAdapters.TaxisTableAdapter taxisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTaxiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

