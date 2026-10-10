namespace OOPGenericCollections
{
    using System;
    using System.Collections;
    class Program
    {
        static void Main (string[] args)
        {
            //Employee 1.
            Employee anna = new Employee
            {
                ID = "E593",
                Name = "Anna",
                Gender = "Kvinna",
                Salary = 50000000
            };
            //Employee 2.
            Employee fredrik = new Employee
            {
                ID = "E631",
                Name = "Fredrik",
                Gender = "Man",
                Salary = 600000
            };
            //Employee 3.
            Employee essa = new Employee
            {
                ID = "E459",
                Name = "Essa",
                Gender = "Man",
                Salary = 500000
            };
            //Employee 4.
            Employee antonio = new Employee
            {
                ID = "E325",
                Name = "Antonio",
                Gender = "Man",
                Salary = 400000
            };
            //Employee 5.
            Employee lillemor = new Employee
            {
                ID = "E232",
                Name = "Lillemor",
                Gender = "Kvinna",
                Salary = 35000
            };
            //Creation of my stack.
            Stack<Employee> staffStack = new Stack<Employee>();

            //Pushing the employee objects onto the stack.
            staffStack.Push(anna);
            staffStack.Push(fredrik);

            staffStack.Push(essa);
            staffStack.Push(antonio);
            staffStack.Push(lillemor);

            //Foreach loop that prints out values of properties of the objects in the Stack.
            foreach (Employee i in staffStack)
            {
                string employeeProfile = i.ID + " " + i.Name + " " + i.Gender + " " + i.Salary;
                int numberOfObjects = staffStack.Count();
                Console.Write(employeeProfile);
                //Is supposed to count the objects in the stack but doesn't actually do it.
                Console.WriteLine(numberOfObjects + " objects are left in the stack.");
                Console.WriteLine("_____________________________"); //Creates some space in between the employee profiles.
                
            }
        }
    }
}