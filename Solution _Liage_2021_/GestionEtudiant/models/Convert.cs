﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.models
{
    public class Convert
    {
       public static string ListToString(List<String> modules)
        {
            string moduleString = "";
            foreach(var elt in modules)
            {
                moduleString += elt + ";";

            }
            return moduleString;
        }

        public static List<String> StringToList(String modules)
        {
            List<String> lModules = new List<string>();
            modules.ToList();
            return modules.Split(';').ToList();

        }

    }
}
