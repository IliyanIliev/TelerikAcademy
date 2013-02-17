using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo
{
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company name:");
            string companyName = Console.ReadLine();
            Console.WriteLine("Address:");
            string address = Console.ReadLine();
            Console.WriteLine("Phone:");
            string phone = Console.ReadLine();
            Console.WriteLine("Fax:");
            string fax = Console.ReadLine();
            Console.WriteLine("Website:");
            string website = Console.ReadLine();
            Console.WriteLine("Manager first name:");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("Manager last name:");
            string managerLastName = Console.ReadLine();
            Console.WriteLine("Manager age:");
            string managerAge = Console.ReadLine();
            Console.WriteLine("Manager phone:");
            string managerPhone = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Here is some information for the company {0}.",companyName);
            Console.WriteLine("Address: {0}",address);
            Console.WriteLine("Phone: {0}",phone);
            Console.WriteLine("Fax: {0}",fax);
            Console.WriteLine("Website: {0}",website);
            Console.WriteLine();
            Console.WriteLine(" Here is some info about the manager:");
            Console.WriteLine("Manager first name: {0}",managerFirstName);
            Console.WriteLine("Manager last name: {0}",managerLastName);
            Console.WriteLine("Manager age: {0}",managerAge);
            Console.WriteLine("Manager phone: {0}",phone);


        }
    }
}
