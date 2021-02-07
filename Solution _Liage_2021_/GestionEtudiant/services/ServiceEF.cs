﻿using GestionEtudiant.entityframework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionEtudiant.models;

namespace GestionEtudiant.services
{
    //Implementatio
    class ServiceEF : IService<classe, personne>
    {
        //context = dao + models
        private gestion_etudiantEntities1 ctx = new gestion_etudiantEntities1();
        public bool AttribuerClasse(classe cl, personne pers, List<string> modules, string annee)
        {
            //1-Professeur existe
                //Attribuer classe
            //2-Professeur n'existe pas
                //Creer le professeur
                if(pers.id == 0)
                     {
                    ctx.personne.Add(pers);
                    ctx.SaveChanges() ;
                     }

            detail d = new detail()
                {
                professeur_id = pers.id,
                classe_id = cl.id,
                annee=annee,
                modules=models.Convert.ListToString(modules)
                };
            ctx.detail.Add(d);

            return ctx.SaveChanges()!=0;



                //Attribuer classe
        }

        public personne ChercherProfesseurParMatricule(string matricule)
        {
            return ctx.personne.Where(
                (f) => f.type.CompareTo("Professeur")==0 && f.matricule.CompareTo(matricule)==0
                ).FirstOrDefault();
        }

        public bool CreerClasse(classe cl)
        {
            ctx.classe.Add(cl);
            return ctx.SaveChanges()!=0;
        }

        public bool CreerPersonne(personne pers)
        {
            ctx.personne.Add(pers);
            return ctx.SaveChanges() != 0;
        }

        public List<classe> ListerClasse()
        {
            return ctx.classe.ToList();
        }

        public DataTable ListerEtudiantParClasse(classe cl)
        {
            //LINQ To Entity F => SQL
             ctx.personne.Where(
                (p)=> p.type.CompareTo("Etudiant")==0 && p.classe_id == cl.id
                ).ToList();
            return null;
        }

        public List<string> ListerModulesProfesseurParClasse(classe cl,personne pers)
        {
            var detail= ctx.detail.Where(
                (d)=> d.professeur_id==pers.id && d.classe_id==cl.id
                ).FirstOrDefault();
            return models.Convert.StringToList(detail.modules);
        }


        public List<personne> ListerProfesseur()
        {
            return ctx.personne.Where(
                (p) => p.type.CompareTo("Professeur") == 0 
                ).ToList();
        }

        public personne SeConnecter(string login, string pwd)
        {
            return ctx.personne.Where(
                (p) => p.login.CompareTo(login) == 0 && p.pwd.CompareTo(pwd) == 0
                ).FirstOrDefault();
        }

        public List<String> ListerModules()
        {
            return new List<string>()
            {
                "", "Webmastering", "UML", "JAVA", "Windev"
            };
        }

        public List<String> ListerGrade()
        {
            return new List<string>()
            {
                "", "Docteur", "Ingenieur", "Professeur", "Master"
            };
        }

        public List<classe> ClassesEnseignees(personne prof)
        {
            var details = prof.detail;
            List<classe> lClasses = new List<classe>();

            foreach(detail det in details)
            {
                lClasses.Add(det.classe);
            }
            return lClasses;
        }
    }
}
