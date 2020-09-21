using System;
using System.ComponentModel.DataAnnotations;

namespace EmploymentManagement.Model
{
    public class Department
    {
        [Key]
        public int DepartemntID { get; set; }
        public string DepartemntName{ get; set; }
    }
}
