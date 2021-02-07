using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionEtudiant.dao;
using GestionEtudiant.models;

namespace Fondamentaux
{
    static class Program
    {
        static void Main(string[] args)
        {
            #region Test DaoClasse

            //1-creer un objet DaoClasse

            DaoClasse dao = new DaoClasse();
            Classe classe = new Classe()
            {

                Libelle = "LIAGE3",
                NbreEtudiant = 30

            }; 
            Console.WriteLine("avant appel");
            //Console.Read();

            //2-insert()
            dao.Insert(classe);

            //3-findALLClasse() et Afficher
            List<Classe> classes = dao.FindAll();
            foreach(var cl in classes)
            {
                Console.WriteLine(cl);
                
            }

            #endregion

        }

    }

}
