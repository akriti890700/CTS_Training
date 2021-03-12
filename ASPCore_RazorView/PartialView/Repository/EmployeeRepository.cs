using RazorViewModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorViewModelBinding.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> EmpList;

        public List<Employee> getEmployees()
        {
            EmpList=new List<Employee>()
            {
                new Employee() { Id = 1, Name = "John", Salary = 10000, IsParmanent = true },
                new Employee() { Id = 2, Name = "Smith", Salary = 5000, IsParmanent = false },
                new Employee() { Id = 3, Name = "Mark", Salary = 5000, IsParmanent = false },
                new Employee() { Id = 4, Name = "Mary", Salary = 5000, IsParmanent = false },
            };
            return EmpList;
        }
        public Employee GetById(int id)
        {

            return EmpList.FirstOrDefault(i => i.Id == id);
        }
    }
}
