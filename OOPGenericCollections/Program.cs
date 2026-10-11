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
                Gender = "Woman",
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
                Gender = "Woman",
                Salary = 35000
            };
            //Creation of object for the InfoTools class, so that we may have access to the methods of the class.
            InfoTools infoTools = new InfoTools();

            //Pushing each created object onto the stack for the first time.
            infoTools.Pusher(anna, fredrik, essa, antonio, lillemor);

            Console.WriteLine("Printing employee profile information.");
            //Printing out the properties of each object.
            infoTools.ProfilePrinter();

            Console.WriteLine("Popping each individual in the stack");
            //Popping each element of the stack.
            infoTools.Popper(lillemor);
            infoTools.Popper(antonio);

            infoTools.Popper(essa);
            infoTools.Popper(fredrik);

            infoTools.Popper(anna);

            //Pushing back the objects on the stack again, after having been removed by the Popper method above.
            infoTools.Pusher(anna, fredrik, essa, antonio, lillemor);
            //Peeking at the properties of the objects.
            infoTools.Peeker(lillemor);
            infoTools.Peeker(antonio);

            //Code block for checking if there is a third element of staffStack and additionally printing the properties of the object out if that is the case.
            int loopCounter = 0;
            foreach (Employee e in infoTools.staffStack)
            {
                
                loopCounter = loopCounter + 1;
                if (loopCounter == 3)
                {
                    if (e.ID != null && e.Name != null && e.Gender != null && e.Salary != 0)
                    {
                        string eProfile = e.ID + " " + e.Name + " " + e.Gender + " " + e.Salary;

                        Console.WriteLine(eProfile);
                        Console.WriteLine("______________________________________");
                    }
                    else
                    {
                        Console.WriteLine("There is no third element.");
                    }
                }
            }

            //Creation of object so that we may access the List and associated methods.
            ListManagement listManagement = new ListManagement();

            //Adding the objects to the list.
            listManagement.staffList.Add(anna);
            listManagement.staffList.Add(fredrik);

            listManagement.staffList.Add(essa);
            listManagement.staffList.Add(antonio);

            listManagement.staffList.Add(lillemor);

            //Using the method for finding the second employee in the list.
            listManagement.FindEmployee2();

            //Using a method for finding the first male.
            listManagement.FindFirstMale();

            listManagement.FindAllMales();

        }
        
    }
}