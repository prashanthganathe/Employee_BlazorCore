using EmploymentManagement.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagmentAPI
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(new Department { DepartemntID=1, DepartemntName="Dep1" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartemntID = 2, DepartemntName = "IT" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartemntID = 3, DepartemntName = "Security" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartemntID = 4, DepartemntName = "Sales" });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "firstname1",
                LastName = "lastname1",
                Email = "first@gmail.com",
                DateOfBirth = new DateTime(1980, 01, 02),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/john.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "two",
                LastName = "lastname1",
                Email = "first@gmail.com",
                DateOfBirth = new DateTime(1980, 01, 02),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "images/two.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "third",
                LastName = "lastname1",
                Email = "first@gmail.com",
                DateOfBirth = new DateTime(1980, 01, 02),
                Gender = Gender.Male,
                DepartmentId = 3,
                PhotoPath = "images/third.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "fourth",
                LastName = "lastname1",
                Email = "first@gmail.com",
                DateOfBirth = new DateTime(1980, 01, 02),
                Gender = Gender.Male,
                DepartmentId = 4,
                PhotoPath = "images/fourth.png"
            });
        }
    }
}
