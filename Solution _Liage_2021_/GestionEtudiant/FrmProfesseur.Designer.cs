namespace GestionEtudiant
{
    partial class FrmProfesseur
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboModules = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lboModulesEnseignes = new System.Windows.Forms.ListBox();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.cboClasse = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddModules = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lboClassesEnseignees = new System.Windows.Forms.ListBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAttribuerClasses = new System.Windows.Forms.Button();
            this.btnAddClasse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddClasse);
            this.groupBox1.Controls.Add(this.cboClasse);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboGrade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNomPrenom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMatricule);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1106, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Donnees Professeur";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricule";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(267, 59);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(260, 39);
            this.txtMatricule.TabIndex = 1;
            this.txtMatricule.TextChanged += new System.EventHandler(this.txtMatricule_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom et Prenom";
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(267, 115);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(260, 39);
            this.txtNomPrenom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(618, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Modules";
            // 
            // cboModules
            // 
            this.cboModules.FormattingEnabled = true;
            this.cboModules.Location = new System.Drawing.Point(188, 59);
            this.cboModules.Name = "cboModules";
            this.cboModules.Size = new System.Drawing.Size(233, 40);
            this.cboModules.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnAddModules);
            this.groupBox2.Controls.Add(this.lboModulesEnseignes);
            this.groupBox2.Controls.Add(this.cboModules);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 387);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modules";
            // 
            // lboModulesEnseignes
            // 
            this.lboModulesEnseignes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboModulesEnseignes.FormattingEnabled = true;
            this.lboModulesEnseignes.ItemHeight = 29;
            this.lboModulesEnseignes.Location = new System.Drawing.Point(145, 175);
            this.lboModulesEnseignes.Name = "lboModulesEnseignes";
            this.lboModulesEnseignes.Size = new System.Drawing.Size(443, 149);
            this.lboModulesEnseignes.TabIndex = 0;
            // 
            // cboGrade
            // 
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(736, 58);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(330, 40);
            this.cboGrade.TabIndex = 8;
            // 
            // cboClasse
            // 
            this.cboClasse.FormattingEnabled = true;
            this.cboClasse.Location = new System.Drawing.Point(736, 107);
            this.cboClasse.Name = "cboClasse";
            this.cboClasse.Size = new System.Drawing.Size(330, 40);
            this.cboClasse.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(618, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Classe";
            // 
            // btnAddModules
            // 
            this.btnAddModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddModules.Location = new System.Drawing.Point(473, 60);
            this.btnAddModules.Name = "btnAddModules";
            this.btnAddModules.Size = new System.Drawing.Size(115, 39);
            this.btnAddModules.TabIndex = 8;
            this.btnAddModules.Text = "Add";
            this.btnAddModules.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Modules Enseignes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lboClassesEnseignees);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(764, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(550, 387);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Classes Enseignees";
            // 
            // lboClassesEnseignees
            // 
            this.lboClassesEnseignees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboClassesEnseignees.FormattingEnabled = true;
            this.lboClassesEnseignees.ItemHeight = 29;
            this.lboClassesEnseignees.Location = new System.Drawing.Point(54, 59);
            this.lboClassesEnseignees.Name = "lboClassesEnseignees";
            this.lboClassesEnseignees.Size = new System.Drawing.Size(443, 265);
            this.lboClassesEnseignees.TabIndex = 0;
            this.lboClassesEnseignees.SelectedIndexChanged += new System.EventHandler(this.lboClassesEnseignees_SelectedIndexChanged);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(1167, 146);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(147, 39);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAttribuerClasses
            // 
            this.btnAttribuerClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttribuerClasses.Location = new System.Drawing.Point(1167, 76);
            this.btnAttribuerClasses.Name = "btnAttribuerClasses";
            this.btnAttribuerClasses.Size = new System.Drawing.Size(147, 39);
            this.btnAttribuerClasses.TabIndex = 11;
            this.btnAttribuerClasses.Text = "Attribuer";
            this.btnAttribuerClasses.UseVisualStyleBackColor = true;
            // 
            // btnAddClasse
            // 
            this.btnAddClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClasse.Location = new System.Drawing.Point(951, 162);
            this.btnAddClasse.Name = "btnAddClasse";
            this.btnAddClasse.Size = new System.Drawing.Size(115, 39);
            this.btnAddClasse.TabIndex = 10;
            this.btnAddClasse.Text = "Add";
            this.btnAddClasse.UseVisualStyleBackColor = true;
            this.btnAddClasse.Click += new System.EventHandler(this.btnAddClasse_Click);
            // 
            // FrmProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 681);
            this.Controls.Add(this.btnAttribuerClasses);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProfesseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Etudiant";
            this.Load += new System.EventHandler(this.FrmProfesseur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboClasse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboModules;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddModules;
        private System.Windows.Forms.ListBox lboModulesEnseignes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lboClassesEnseignees;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAttribuerClasses;
        private System.Windows.Forms.Button btnAddClasse;
    }
}