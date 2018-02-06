using BangazonDepartments.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonDepartments
{
    class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Department>();

            var hr = new HR
            (
                 "HR",
                 "Adam Smith",
                  3
            );

            var it = new ITS
            (
                "ITS",
                "Foo Bar",
                16
            );

            departments.Add(hr);
            departments.Add(it);

            foreach (Department d in departments)
            {
                Console.WriteLine($"{d.toString()}");
            }

            hr.AddPolicy("T-1-23-B-12", "The policy on policies");

            var policies = hr.GetPolicies();

            foreach (KeyValuePair<string, string> policy in policies)
            {
                Console.WriteLine($"{policy.Key} - {policy.Value}");
            }

            Console.ReadLine();
        }
    }
}
