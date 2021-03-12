using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorViewModelBinding.Models
{
    public interface IEmployeeRepository
    {
        public List<Employee> getEmployees();
        public Employee GetById(int id);
    }
}
