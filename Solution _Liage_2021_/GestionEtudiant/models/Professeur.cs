using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.models
{
    class Professeur : Personne
    
    {
        private string grade;
        private string matricule;
        private List<String> modules;

        public string Grade { get => grade; set => grade = value; }
        public List<string> Modules { get => modules; set => modules = value; }
        public string Matricule { get => matricule; set => matricule = value; }

        public Professeur(int id, string nomComplet, string matricule, string grade): base(id, nomComplet)
        {
            this.grade = grade;
            this.matricule = matricule;
            Type = "Professeur";
        }

        public Professeur(string nomComplet,string matricule, string grade) : base(nomComplet)
        {
            this.grade = grade;
            this.matricule = matricule;
            Type = "Professeur";

        }

        public Professeur()
        {
            Type = "Professeur";
        }
    }
}
