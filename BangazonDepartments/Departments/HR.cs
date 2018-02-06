using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonDepartments.Departments
{
    public class HR : Department
    {
        private Dictionary<string, string> _policies = new Dictionary<string, string>();


        public HR(string deptName, string managerName, int fte) : base(deptName, managerName, fte)
        {
        }

        public void AddPolicy (string title, string text)
        {
            _policies.Add(title, text);
        }

        public Dictionary<string, string> GetPolicies()
        {
            return _policies;
        }

    }
}
