﻿
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
            this.mATEMATICASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.coneccionesBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.areglosToolStripMenuItem,
            this.mATEMATICASToolStripMenuItem,
            this.coneccionesBDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // mATEMATICASToolStripMenuItem
            // 
            this.mATEMATICASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumasToolStripMenuItem,
            this.restaToolStripMenuItem});
            this.mATEMATICASToolStripMenuItem.Name = "mATEMATICASToolStripMenuItem";
            this.mATEMATICASToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.mATEMATICASToolStripMenuItem.Text = "Matematicas";
            // 
            // sumasToolStripMenuItem
            // 
            this.sumasToolStripMenuItem.Name = "sumasToolStripMenuItem";
            this.sumasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sumasToolStripMenuItem.Text = "Suma";
            this.sumasToolStripMenuItem.Click += new System.EventHandler(this.sumasToolStripMenuItem_Click);
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restaToolStripMenuItem.Text = "Resta";
            this.restaToolStripMenuItem.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // coneccionesBDToolStripMenuItem
            // 
            this.coneccionesBDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDToolStripMenuItem});
            this.coneccionesBDToolStripMenuItem.Name = "coneccionesBDToolStripMenuItem";
            this.coneccionesBDToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.coneccionesBDToolStripMenuItem.Text = "Conecciones BD";
            // 
            // cRUDToolStripMenuItem
            // 
            this.cRUDToolStripMenuItem.Name = "cRUDToolStripMenuItem";
            this.cRUDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cRUDToolStripMenuItem.Text = "CRUD";
            this.cRUDToolStripMenuItem.Click += new System.EventHandler(this.cRUDToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormMenu_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mATEMATICASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coneccionesBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDToolStripMenuItem;
    }
}