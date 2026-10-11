using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGenericCollections
{
    internal class InfoTools
    {
        //Creation of my stack.
        public Stack<Employee> staffStack = new Stack<Employee>();
        //Pushes objects onto the staffStack
        public void Pusher(Employee anna, Employee fredrik, Employee essa, Employee antonio, Employee lillemor)
        {
            //Pushing the employee objects onto the stack.
            staffStack.Push(anna);
            staffStack.Push(fredrik);

            staffStack.Push(essa);
            staffStack.Push(antonio);
            staffStack.Push(lillemor);
        }

        public void ProfilePrinter()
        {
            //Foreach loop that prints out values of properties of the objects in the Stack.
            foreach (Employee j in staffStack)
            {
                string jProfile = j.ID + " " + j.Name + " " + j.Gender + " " + j.Salary;
                int numberOfObjects = staffStack.Count();
                Console.Write(jProfile);
                //Is supposed to count the objects in the stack but doesn't actually do it.
                Console.WriteLine(numberOfObjects + " objects are left in the stack.");
                Console.WriteLine("_____________________________"); //Creates some space in between the employee profiles.
            }
        }

        public void Popper()
        {
            //Popping the entire stack with the pop method.
            for (int i = 0; i < 5; i++)
            {

                staffStack.Pop();

                Console.WriteLine(staffStack.Count());
            }
        }
    }
}
