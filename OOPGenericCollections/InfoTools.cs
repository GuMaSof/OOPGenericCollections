using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGenericCollections
{
    internal class InfoTools
    {
        //Creation of a stack for employee objects.
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
        //Prints out the profile information of each employee.
        public void ProfilePrinter()
        {
            //Foreach loop that prints out values of properties of the objects in the Stack.
            foreach (Employee j in staffStack)
            {
                string jProfile = j.ID + " " + j.Name + " " + j.Gender + " " + j.Salary;
                
                Console.Write(jProfile);
                //Is supposed to count the objects in the stack but doesn't actually do it.
                Console.WriteLine(staffStack.Count + " objects are left in the stack.");
                Console.WriteLine("_____________________________"); //Creates some space in between the employee profiles.
            }
        }
        //Pops all elements of the stack.
        public void Popper()
        {
            Console.WriteLine(staffStack.Pop().ID);

            Console.WriteLine(staffStack.Count());
            
        }
        //Peeks at objects inside of the stack.
        public void Peeker(Employee e)
        {
            //Loop that peeks at two objects.
            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine(staffStack.Peek().ID);

                Console.WriteLine(staffStack.Count());
            }
        }
    }
}
