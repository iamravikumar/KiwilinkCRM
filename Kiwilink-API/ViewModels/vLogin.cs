﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kiwilink.Models;
using Kiwilink.Data;

namespace Kiwilink.ViewModels
{
    public class vLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Employee Authenticate()
        {
            return DB.Collection<Employee>().SingleOrDefault(e => e.Name.Equals(Username) && e.Password.Equals(Password));
        }
    }
}