using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.models
{
    public class Classe
    {
        //Attributs
        private int id;
        private int nbreEtudiant;
        
        //Constructeurs
        //Surcharge
        //Par defaut
        public Classe()
        {
        }

        //Insertion

        public Classe(string libelle, int nbreEtudiant)
        {
            this.Libelle = libelle;
            this.nbreEtudiant = nbreEtudiant;
        }

        public Classe(int id)
        {
            this.id = id;
        }


        //Selection
        public Classe(int id, string libelle, int nbreEtudiant)
        {
            this.id = id;
            this.Libelle = libelle;
            this.nbreEtudiant = nbreEtudiant;
        }


        //Get et Set ==> Proprietes
        public int Id { get => id; set => id = value; }
        public string Libelle { get; set; }
        public int NbreEtudiant{ get => nbreEtudiant; set => nbreEtudiant = value; }


        //ToString()

        public override string ToString()
        {
            return base.ToString();
        }



    }
}
