using GestionEtudiant.entityframework;
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
    public partial class FrmInscription : Form
    {
        private ServiceEF metierEF = new ServiceEF();

        public FrmInscription()
        {
            InitializeComponent();
        }

        private void FrmInscription_Load(object sender, EventArgs e)
        {
            //Chargement du ComboBox
            //Propriete affichier => DisplayMember
            //Propriete retour apres Select d'un elt du combo => ValueMember
            cboClasse.DataSource = metierEF.ListerClasse();
            cboClasse.DisplayMember = "libelle";
            cboClasse.ValueMember = "id";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Inscription d'un Etudiant
            if (string.IsNullOrEmpty(txtNomPrenom.Text)
                || string.IsNullOrEmpty(txtTuteur.Text))
            {
                MessageBox.Show(
                    "Champs Obligatoires",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                personne pers = new personne()
                {
                    nom_complet = txtNomPrenom.Text.Trim(),
                    tuteur = txtTuteur.Text.Trim(),
                    type = "Etudiant",
                    classe_id = int.Parse(cboClasse.SelectedValue.ToString())
                };
                if (metierEF.CreerPersonne(pers))
                {
                    MessageBox.Show(
                    "Etudiant inscrit avec succes",
                    "Information",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );

                }
                else
                {
                    MessageBox.Show(
                    "Erreur d'Inscription",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                }
            }

            }
    }
}
