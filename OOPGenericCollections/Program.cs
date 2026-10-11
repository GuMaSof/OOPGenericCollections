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

            infoTools.Pusher(anna, fredrik, essa, antonio, lillemor);

            infoTools.ProfilePrinter();

            infoTools.Popper(lillemor);
            infoTools.Popper(antonio);

            infoTools.Popper(essa);
            infoTools.Popper(fredrik);

            infoTools.Popper(anna);
            //infoTools.Pusher(anna, fredrik, essa, antonio, lillemor);

            //infoTools.Peeker(anna);
        }
        
    }
}