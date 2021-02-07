using GestionEtudiant.models;
using GestionEtudiant.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEtudiant
{
    public partial class FrmConnexion : Form
    {
        Service metier = new Service();
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            //1-Verifier les champs
            if(string.IsNullOrEmpty(txtLogin.Text)
                || string.IsNullOrEmpty(txtPwd.Text))
            {
                lblError.Text = "Login ou Mot de Passe Obligatoire";
                lblError.Visible = true;
            }
            else
            {
                //2-Champs valides
                Personne pers = metier.SeConnecter(txtLogin.Text.Trim(), txtPwd.Text.Trim());
                if (pers == null)
                {
                    lblError.Text = "Login ou Mot de Passe Incorrect";
                    lblError.Visible = true;
                }
                else
                {
                    //Ouvrir FrmMEnu
                    FrmMenu frmMenu = new FrmMenu();
                    frmMenu.Show();
                    this.Hide();

                }
            }
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtPwd.Clear();
        }

        private void FrmConnexion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
