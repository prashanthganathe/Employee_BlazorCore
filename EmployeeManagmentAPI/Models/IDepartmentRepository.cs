﻿using EmploymentManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagmentAPI.Models
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
         Department GetDepartment(int departmentID);
    }
}
