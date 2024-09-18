namespace FlotaTaxisApp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.taxisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conductoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasajerosToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taxisToolStripMenuItem,
            this.conductoresToolStripMenuItem,
            this.ViajesToolStripMenuItem,
            this.pasajerosToolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(284, 165);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // taxisToolStripMenuItem
            // 
            this.taxisToolStripMenuItem.Name = "taxisToolStripMenuItem";
            this.taxisToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.taxisToolStripMenuItem.Text = "Taxis";
            this.taxisToolStripMenuItem.Click += new System.EventHandler(this.taxisToolStripMenuItem_Click);
            // 
            // conductoresToolStripMenuItem
            // 
            this.conductoresToolStripMenuItem.Name = "conductoresToolStripMenuItem";
            this.conductoresToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.conductoresToolStripMenuItem.Text = "Conductores";
            this.conductoresToolStripMenuItem.Click += new System.EventHandler(this.conductoresToolStripMenuItem_Click);
            // 
            // ViajesToolStripMenuItem
            // 
            this.ViajesToolStripMenuItem.Name = "ViajesToolStripMenuItem";
            this.ViajesToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.ViajesToolStripMenuItem.Text = "Viajes";
            this.ViajesToolStripMenuItem.Click += new System.EventHandler(this.ViajesToolStripMenuItem_Click);
            // 
            // pasajerosToolStripMenuItem4
            // 
            this.pasajerosToolStripMenuItem4.Name = "pasajerosToolStripMenuItem4";
            this.pasajerosToolStripMenuItem4.Size = new System.Drawing.Size(68, 20);
            this.pasajerosToolStripMenuItem4.Text = "Pasajeros";
            this.pasajerosToolStripMenuItem4.Click += new System.EventHandler(this.pasajerosToolStripMenuItem4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 165);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taxisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conductoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasajerosToolStripMenuItem4;
    }
}