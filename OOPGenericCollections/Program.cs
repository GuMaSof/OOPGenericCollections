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
            InfoTools infoTools = new InfoTools();

            infoTools.Pusher(anna, fredrik, essa, antonio, lillemor);

            //Foreach loop that prints out values of properties of the objects in the Stack.
            foreach (Employee j in staffStack)
            {
                string jProfile = j.ID + " " + j.Name + " " + j.Gender + " " + j.Salary;
                int numberOfObjects = infoTools.staffStack.Count();
                Console.Write(jProfile);
                //Is supposed to count the objects in the stack but doesn't actually do it.
                Console.WriteLine(numberOfObjects + " objects are left in the stack.");
                Console.WriteLine("_____________________________"); //Creates some space in between the employee profiles.
                
            }

            

            staffStack.Push(anna);
            staffStack.Push(fredrik);

            staffStack.Push(essa);
            staffStack.Push(antonio);
            staffStack.Push(lillemor);

            //Loop that peeks at two objects.
            for (int i = 0; i < 2; i++)
            {

                staffStack.Peek();

                Console.WriteLine(staffStack.Count());
            }
        }
        static void Popper(T variable)
        {
            //Popping the entire stack with the pop method.
            for (int i = 0; i < 5; i++)
            {

                infoTools.staffStack.Pop();

                Console.WriteLine(staffStack.Count());
            }
        }
    }
}