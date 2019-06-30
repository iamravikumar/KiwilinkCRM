﻿using Kiwilink.Models;
using MongoDB.Entities;
using System.Linq;

namespace Kiwilink.ViewModels
{
    public class vLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Employee Authenticate()
        {
            return DB.Queryable<Employee>().SingleOrDefault(e => e.Name.Equals(Username) && e.Password.Equals(Password));
        }
    }
}
