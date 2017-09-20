using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class Employeecontext : DbContext

    {


        public Employeecontext() : base("name = MyConnectionString")
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }



    }
}