namespace CineApp
{
    partial class Main
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
            this.msMainCine = new System.Windows.Forms.MenuStrip();
            this.peliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDePeliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainCine.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainCine
            // 
            this.msMainCine.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMainCine.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMainCine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peliculasToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.consultasToolStripMenuItem1});
            this.msMainCine.Location = new System.Drawing.Point(0, 0);
            this.msMainCine.Name = "msMainCine";
            this.msMainCine.Size = new System.Drawing.Size(800, 33);
            this.msMainCine.TabIndex = 0;
            this.msMainCine.Text = "Menu";
            // 
            // peliculasToolStripMenuItem
            // 
            this.peliculasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargaDePeliculasToolStripMenuItem});
            this.peliculasToolStripMenuItem.Name = "peliculasToolStripMenuItem";
            this.peliculasToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.peliculasToolStripMenuItem.Text = "Peliculas";
            // 
            // cargaDePeliculasToolStripMenuItem
            // 
            this.cargaDePeliculasToolStripMenuItem.Name = "cargaDePeliculasToolStripMenuItem";
            this.cargaDePeliculasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cargaDePeliculasToolStripMenuItem.Text = "Carga de Peliculas";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.ventasToolStripMenuItem.Text = "Horarios";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.consultasToolStripMenuItem.Text = "Ventas";
            // 
            // consultasToolStripMenuItem1
            // 
            this.consultasToolStripMenuItem1.Name = "consultasToolStripMenuItem1";
            this.consultasToolStripMenuItem1.Size = new System.Drawing.Size(105, 29);
            this.consultasToolStripMenuItem1.Text = "Consultas";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msMainCine);
            this.MainMenuStrip = this.msMainCine;
            this.Name = "Main";
            this.Text = "Menu Principal: Cine";
            this.msMainCine.ResumeLayout(false);
            this.msMainCine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainCine;
        private System.Windows.Forms.ToolStripMenuItem peliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDePeliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem1;
    }
}

