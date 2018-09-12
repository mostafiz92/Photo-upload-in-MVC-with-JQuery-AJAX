using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JqueryAjaxCRUD.Models
{
    public class EmployeesContext:DbContext
    {
        public EmployeesContext() : base("EmployeesContext") { }

        public DbSet<Employee> Employees { get; set; }
    }
}