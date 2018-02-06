using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonDepartments.Departments
{
    public class ITS : Department
    {
        private int _computerResources { get; set; }

        public ITS(string deptName, string managerName, int fte) : base(deptName, managerName, fte)
        {
        }

        public int AddComputer(int computer)
        {
            return _computerResources += computer; 
        }
    }
}
