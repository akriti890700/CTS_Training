using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorViewModelBinding.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal Salary { get; set; }
        public bool IsParmanent { get; set; }
        public List<Employee> employees { get; set; }

    }
}
