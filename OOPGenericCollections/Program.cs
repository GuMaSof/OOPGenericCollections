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
            //Creation of object for the InfoTools class, so that we may have access to the methods of the class.
            InfoTools infoTools = new InfoTools();

            //Pushing each created object onto the stack for the first time.
            infoTools.Pusher(anna, fredrik, essa, antonio, lillemor);

            //Printing out the properties of each object.
            infoTools.ProfilePrinter();

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

            infoTools.Peeker(essa);
            infoTools.Peeker(fredrik);

            infoTools.Peeker(anna);
        }
        
    }
}