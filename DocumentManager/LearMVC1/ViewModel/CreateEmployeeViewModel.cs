﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearMVC1.ViewModel
{
    public class CreateEmployeeViewModel:BaseViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; }

    }
}