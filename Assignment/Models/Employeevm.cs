using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class Employeevm
    {
        public int Id { get; set; }
        public Employee Employees { get; set; }
        public IEnumerable<State> States { get; set; }
        public IEnumerable<City> Cities { get; set; }
    }
}