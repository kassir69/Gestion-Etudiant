using GestionEtudiant.entityframework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.services
{
    interface IService<C,P>
    {
        //Classe ==> ADO.NET
        //Classe ==> EF
        DataTable ListerEtudiantParClasse(classe cl);
        bool CreerClasse(classe cl);
        List<C> ListerClasse();
        bool CreerPersonne(P pers);
        P SeConnecter(String login, String pwd);
        P ChercherProfesseurParMatricule(String matricule);
        bool AttribuerClasse(C cl, P pers, List<String> modules, String annee);
        List<P> ListerProfesseur();
        List<String> ListerModulesProfesseurParClasse(C cl, P pers);


    }
}
