namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cADASTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mARCASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vEÍCULOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vEÍCULOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOCAÇÃOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROSToolStripMenuItem,
            this.lOCAÇÃOToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROSToolStripMenuItem
            // 
            this.cADASTROSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mARCASToolStripMenuItem,
            this.vEÍCULOSToolStripMenuItem,
            this.vEÍCULOToolStripMenuItem,
            this.cLIENTEToolStripMenuItem});
            this.cADASTROSToolStripMenuItem.Name = "cADASTROSToolStripMenuItem";
            this.cADASTROSToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.cADASTROSToolStripMenuItem.Text = "CADASTROS E CONSULTAS";
            this.cADASTROSToolStripMenuItem.Click += new System.EventHandler(this.cADASTROSToolStripMenuItem_Click);
            // 
            // mARCASToolStripMenuItem
            // 
            this.mARCASToolStripMenuItem.Name = "mARCASToolStripMenuItem";
            this.mARCASToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mARCASToolStripMenuItem.Text = "MARCA";
            this.mARCASToolStripMenuItem.Click += new System.EventHandler(this.mARCASToolStripMenuItem_Click);
            // 
            // vEÍCULOSToolStripMenuItem
            // 
            this.vEÍCULOSToolStripMenuItem.Name = "vEÍCULOSToolStripMenuItem";
            this.vEÍCULOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vEÍCULOSToolStripMenuItem.Text = "MODELO";
            this.vEÍCULOSToolStripMenuItem.Click += new System.EventHandler(this.vEÍCULOSToolStripMenuItem_Click);
            // 
            // vEÍCULOToolStripMenuItem
            // 
            this.vEÍCULOToolStripMenuItem.Name = "vEÍCULOToolStripMenuItem";
            this.vEÍCULOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vEÍCULOToolStripMenuItem.Text = "VEÍCULO";
            this.vEÍCULOToolStripMenuItem.Click += new System.EventHandler(this.vEÍCULOToolStripMenuItem_Click);
            // 
            // cLIENTEToolStripMenuItem
            // 
            this.cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cLIENTEToolStripMenuItem.Text = "CLIENTE";
            this.cLIENTEToolStripMenuItem.Click += new System.EventHandler(this.cLIENTEToolStripMenuItem_Click);
            // 
            // lOCAÇÃOToolStripMenuItem1
            // 
            this.lOCAÇÃOToolStripMenuItem1.Name = "lOCAÇÃOToolStripMenuItem1";
            this.lOCAÇÃOToolStripMenuItem1.Size = new System.Drawing.Size(75, 20);
            this.lOCAÇÃOToolStripMenuItem1.Text = "LOCAÇÃO";
            this.lOCAÇÃOToolStripMenuItem1.Click += new System.EventHandler(this.lOCAÇÃOToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cADASTROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOCAÇÃOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mARCASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vEÍCULOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vEÍCULOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem;
    }
}

