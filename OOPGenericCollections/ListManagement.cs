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
        public List<Employee> males = new List<Employee>();
        public void FindEmployee2()
        {
            if (staffList.Contains(staffList[1]))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
        }

        public void FindFirstMale()
        {
            Employee firstMale;
            Console.WriteLine(staffList.Find(firstMale => firstMale.Gender == "Man").Name);
        }

        public void FindAllMales()
        {
            Employee male;
            males = staffList.FindAll(male => male.Gender == "Man");
            
            foreach (Employee employee in males)
            {
                Console.WriteLine(employee.ID + " " + employee.Name);
            }
        }
    }
}
