using EmploymentManagement.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
        //    return  base.OnInitializedAsync();
        }


        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            var e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "firstname1",
                LastName = "lastname1",
                Email = "first@gmail.com",
                DateOfBirth = new DateTime(1980, 01, 02),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/john.jpg"
            };

            var e2 = new Employee
            {
                EmployeeId = 1,
                FirstName = "two",
                LastName = "lastname1",
                Email = "first@gmail.com",
                DateOfBirth = new DateTime(1980, 01, 02),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "images/two.jpg"
            };

            var e3 = new Employee
            { 
                EmployeeId = 1,
                FirstName = "third",
                LastName = "lastname1",
                Email = "first@gmail.com",
                DateOfBirth = new DateTime(1980, 01, 02),
                Gender = Gender.Male,
                DepartmentId = 3,
                PhotoPath = "images/third.jpg"
            };

            var e4 = new Employee
            {
                EmployeeId = 1,
                FirstName = "fourth",
                LastName = "lastname1",
                Email = "first@gmail.com",
                DateOfBirth = new DateTime(1980, 01, 02),
                Gender = Gender.Male,
                DepartmentId = 4,
                PhotoPath = "images/fourth.png"
            };

            Employees = new List<Employee> { e1, e2, e3, e4 };


        }

    }
}
