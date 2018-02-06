using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonDepartments
{
    public class Department
    {
        private string Name { get; set; }
        private string Manager { get; set; }
        private int FTE { get; set; }

        public Department (string deptName, string managerName, int fte)
        {
           Name = deptName;
           Manager = managerName;
           FTE = fte;
        }

        public string toString()
        {
            return $"{Name} {Manager} {FTE}";
        }
    }
}
