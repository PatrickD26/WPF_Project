﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_project.CoucheMétier.AccèsMétier
{
    public interface IDbConnexion
    { 
        ConnectionBdd  retrieveServiceMethods();
    }
}
