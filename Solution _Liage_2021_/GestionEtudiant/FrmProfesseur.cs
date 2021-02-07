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

    public partial class FrmProfesseur : Form
    {
        ServiceEF metier = new ServiceEF();
        public FrmProfesseur()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //1-Charger le comboClasse
            cboClasse.DataSource = metier.ListerClasse();
            cboClasse.DisplayMember = "libelle";
            cboClasse.ValueMember = "id";

            //2-Charger le comboGrade
            cboGrade.DataSource = metier.ListerGrade();

            //3-Charger le comboModules
            cboModules.DataSource = metier.ListerModules();
        }

        private void FrmProfesseur_Load(object sender, EventArgs e)
        {

        }

        personne prof;
        
        private void txtMatricule_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMatricule.Text))
            {
                 prof = metier.ChercherProfesseurParMatricule(txtMatricule.Text.Trim());
                if (prof != null)
                {
                    txtNomPrenom.Text = prof.nom_complet;
                    //Selectionner le grade du prof
                    cboGrade.SelectedItem = prof.grade;
                    //Charger les classes d'un prof
                    // lboClassesEnseignees.DataSource = metier.ClassesEnseignees(prof);
                    //lboClassesEnseignees.DisplayMember = "libelle";
                    LoadLboxClassesEnseignees();
                    LoadLboxModulesEnseignes();
                    //Charger les modules enseignees par un prof dans une classe
                    //classe selectionne
                    //classe classeSelected =(classe) lboClassesEnseignees.SelectedItem;
                    //lboModulesEnseignes.DataSource = metier.
                    //ListerModulesProfesseurParClasse(classeSelected, prof);
                }
                else
                {
                    txtNomPrenom.Clear();
                    //Selectionner le premier elt du combo
                    cboGrade.SelectedIndex=0;
                }
            }
        }

        private void lboClassesEnseignees_SelectedIndexChanged(object sender, EventArgs e)
        {
            //classe selectionne
            // classe classeSelected = (classe)lboClassesEnseignees.SelectedItem;
            // lboModulesEnseignes.DataSource = metier.
            //                                  ListerModulesProfesseurParClasse(classeSelected, prof);
            LoadLboxModulesEnseignes();
        }

        private void btnAddClasse_Click(object sender, EventArgs e)
        {
            /*
             classe classeSelected = (classe) cboClasse.SelectedItem;
            //ajout
            classesEnseignees.Add(classeSelected);
            //vider datasource
            lboClassesEnseignees.DataSource = null;
            //charger listbox de classe


            lboClassesEnseignees.Items.Add(classeSelected);
            //selioctionner classe
            //lboClassesEnseignees.SelectedItem = classeSelected;
            */
           // lboClassesEnseignees.DataSource = null;
           //Vider list box Classe
            lboClassesEnseignees.Items.Clear();
            //Vider list box Modules
            lboModulesEnseignes.Items.Clear();

        }

        private void LoadLboxClassesEnseignees()
        {
            List<classe> classeEnseignees = metier
                                            .ClassesEnseignees(prof);
            foreach(classe cl in classeEnseignees)
            {
                lboClassesEnseignees.Items.Add(cl);
            }
            //Selectionner la premiere classe
            //lboClassesEnseignees.SelectedIndex = 0;
        }

        private void LoadLboxModulesEnseignes()
        {
            classe classeSelected = (classe)lboClassesEnseignees.SelectedItem;
            List<String> modulesEnseignes = metier
                 .ListerModulesProfesseurParClasse(classeSelected, prof);
            lboModulesEnseignes.Items.Clear();
            foreach (string modules in modulesEnseignes)
            {
                lboModulesEnseignes.Items.Add(modules);
            }
        }
    }
} 
