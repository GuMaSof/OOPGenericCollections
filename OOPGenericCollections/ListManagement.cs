using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGenericCollections
{
    //Here we put methods that are concerned with handling the List.
    internal class ListManagement
    {
        //Creation of an employee list so that we may use it later.
        public List<Employee> staffList = new List<Employee>();

        public void FindEmployee2()
        {
            Employee firstMale;
            if (staffList.Contains(firstMale))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
        }

        public void FindFirstMale()
        {
            Employee employee;
            Console.WriteLine(staffList.Find(employee => employee.Gender == "Man").Name);
        }

        public void FindAllMales()
        {
            Employee employee;
            staffList.FindAll()
            
        }
    }
}
