﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.dao
{
    public interface IDao <T>
    {
         int insert(T obj);
    }
}
