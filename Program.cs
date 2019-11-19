using System;
using System.Collections.Generic;

namespace employeeList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company YourMomsHouse = new Company("Your Mom's House Podcast", 2 - 2 - 1977);

            // Create three employees
            Employee Josh = new Employee()
            {
                FirstName = "Josh",
                LastName = "Potter",
                Title = "CEO",
                StartDate = DateTime.Now
            };

            Employee Christina = new Employee()
            {
                FirstName = "Christina",
                LastName = "Pazsitzky",
                Title = "Senior Vice President",
                StartDate = DateTime.Now
            };

            Employee Tommy = new Employee()
            {
                FirstName = "Tommy",
                LastName = "Jeans Segura",
                Title = "Custodian",
                StartDate = DateTime.Now
            };
            // Assign the employees to the company
            YourMomsHouse.NewEmployee.Add(Josh);
            YourMomsHouse.NewEmployee.Add(Christina);
            YourMomsHouse.NewEmployee.Add(Tommy);



            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            YourMomsHouse.ListEmployee();
        }
    }
}