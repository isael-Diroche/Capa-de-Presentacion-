
namespace Capa_de_Presentacion
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editorDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintBasicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userControl21 = new Capa_de_Presentacion.UserControl2();
            this.userControl11 = new Capa_de_Presentacion.UserControl1();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BurlyWood;
            this.menuStrip1.Font = new System.Drawing.Font("DM Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorDeTextoToolStripMenuItem,
            this.paintBasicoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editorDeTextoToolStripMenuItem
            // 
            this.editorDeTextoToolStripMenuItem.Name = "editorDeTextoToolStripMenuItem";
            this.editorDeTextoToolStripMenuItem.Size = new System.Drawing.Size(108, 21);
            this.editorDeTextoToolStripMenuItem.Text = "Editor de texto";
            this.editorDeTextoToolStripMenuItem.Click += new System.EventHandler(this.editorDeTextoToolStripMenuItem_Click);
            // 
            // paintBasicoToolStripMenuItem
            // 
            this.paintBasicoToolStripMenuItem.Name = "paintBasicoToolStripMenuItem";
            this.paintBasicoToolStripMenuItem.Size = new System.Drawing.Size(93, 21);
            this.paintBasicoToolStripMenuItem.Text = "Paint basico";
            this.paintBasicoToolStripMenuItem.Click += new System.EventHandler(this.paintBasicoToolStripMenuItem_Click);
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.NavajoWhite;
            this.userControl21.Location = new System.Drawing.Point(0, 29);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(884, 481);
            this.userControl21.TabIndex = 2;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.SkyBlue;
            this.userControl11.Location = new System.Drawing.Point(0, 28);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(884, 482);
            this.userControl11.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Capa de Presentacion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editorDeTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintBasicoToolStripMenuItem;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
    }
}

