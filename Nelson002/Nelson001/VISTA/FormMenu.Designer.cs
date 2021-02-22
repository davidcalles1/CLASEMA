
namespace Nelson001.VISTA
{
    partial class FormMenu
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
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clikcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areglosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLICKPARAACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.areglosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clikcToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // clikcToolStripMenuItem
            // 
            this.clikcToolStripMenuItem.Name = "clikcToolStripMenuItem";
            this.clikcToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.clikcToolStripMenuItem.Text = "CLICK PARA MAS INFORMACION";
            this.clikcToolStripMenuItem.Click += new System.EventHandler(this.clikcToolStripMenuItem_Click);
            // 
            // areglosToolStripMenuItem
            // 
            this.areglosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLICKPARAACToolStripMenuItem});
            this.areglosToolStripMenuItem.Name = "areglosToolStripMenuItem";
            this.areglosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.areglosToolStripMenuItem.Text = "Areglos ";
            // 
            // cLICKPARAACToolStripMenuItem
            // 
            this.cLICKPARAACToolStripMenuItem.Name = "cLICKPARAACToolStripMenuItem";
            this.cLICKPARAACToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.cLICKPARAACToolStripMenuItem.Text = "CLICK PARA ACCEDER";
            this.cLICKPARAACToolStripMenuItem.Click += new System.EventHandler(this.cLICKPARAACToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clikcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areglosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLICKPARAACToolStripMenuItem;
    }
}