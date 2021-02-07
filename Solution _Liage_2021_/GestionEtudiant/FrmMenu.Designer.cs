namespace GestionEtudiant
{
    partial class FrmMenu
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
            this.classeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attribuerClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classeProfesseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classeToolStripMenuItem,
            this.etudiantToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1273, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // classeToolStripMenuItem
            // 
            this.classeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creerClasseToolStripMenuItem,
            this.attribuerClasseToolStripMenuItem});
            this.classeToolStripMenuItem.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classeToolStripMenuItem.Name = "classeToolStripMenuItem";
            this.classeToolStripMenuItem.Size = new System.Drawing.Size(108, 33);
            this.classeToolStripMenuItem.Text = "Classe";
            // 
            // creerClasseToolStripMenuItem
            // 
            this.creerClasseToolStripMenuItem.Name = "creerClasseToolStripMenuItem";
            this.creerClasseToolStripMenuItem.Size = new System.Drawing.Size(303, 34);
            this.creerClasseToolStripMenuItem.Text = "Creer Classe";
            this.creerClasseToolStripMenuItem.Click += new System.EventHandler(this.creerClasseToolStripMenuItem_Click);
            // 
            // attribuerClasseToolStripMenuItem
            // 
            this.attribuerClasseToolStripMenuItem.Name = "attribuerClasseToolStripMenuItem";
            this.attribuerClasseToolStripMenuItem.Size = new System.Drawing.Size(303, 34);
            this.attribuerClasseToolStripMenuItem.Text = "Attribuer Classe";
            this.attribuerClasseToolStripMenuItem.Click += new System.EventHandler(this.attribuerClasseToolStripMenuItem_Click);
            // 
            // etudiantToolStripMenuItem
            // 
            this.etudiantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscripitionToolStripMenuItem,
            this.classeProfesseurToolStripMenuItem});
            this.etudiantToolStripMenuItem.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etudiantToolStripMenuItem.Name = "etudiantToolStripMenuItem";
            this.etudiantToolStripMenuItem.Size = new System.Drawing.Size(131, 33);
            this.etudiantToolStripMenuItem.Text = "Etudiant";
            // 
            // inscripitionToolStripMenuItem
            // 
            this.inscripitionToolStripMenuItem.Name = "inscripitionToolStripMenuItem";
            this.inscripitionToolStripMenuItem.Size = new System.Drawing.Size(326, 34);
            this.inscripitionToolStripMenuItem.Text = "Inscripition";
            this.inscripitionToolStripMenuItem.Click += new System.EventHandler(this.inscripitionToolStripMenuItem_Click);
            // 
            // classeProfesseurToolStripMenuItem
            // 
            this.classeProfesseurToolStripMenuItem.Name = "classeProfesseurToolStripMenuItem";
            this.classeProfesseurToolStripMenuItem.Size = new System.Drawing.Size(326, 34);
            this.classeProfesseurToolStripMenuItem.Text = "Classe Professeur";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(1136, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(138, 25);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Deconnexion";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 584);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Gestion Etudiant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem classeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creerClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attribuerClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classeProfesseurToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}