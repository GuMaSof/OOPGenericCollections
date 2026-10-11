using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGenericCollections
{
    /*The purpose of this class is to keep a few of the codeblocks out of the way, so that reading the code of the Program class becomes a more smooth experience.
     After all, some of these codeblocks must be used several times.*/
    internal class InfoTools
    {
        //Creation of a stack for employee objects.
        public Stack<Employee> staffStack = new Stack<Employee>();

        /*Pushes objects onto the staffStack.
        This has to be done several times, so it is better to put this codeblock here, and turn into a method for the sake of comfort.*/
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
                
                Console.WriteLine(jProfile);
                //Is supposed to count the objects in the stack but doesn't actually do it.
                Console.WriteLine(staffStack.Count + " objects are left in the stack.");
                Console.WriteLine("_____________________________"); //Creates some space in between the employee profiles.
            }
        }
        //Pops one element of the stack.
        public void Popper(Employee T)
        {
            staffStack.Pop();

            Console.WriteLine(T.ID);
            Console.WriteLine(T.Name);

            Console.WriteLine(T.Gender);
            Console.WriteLine(T.Salary);

            //Counts the elements of the stack.
            Console.WriteLine(staffStack.Count());
            
        }
        //Peeks at objects inside of the stack.
        public void Peeker(Employee T)
        {
            Console.WriteLine(staffStack.Peek().ID);

            Console.WriteLine(staffStack.Count());
        }
    }
}
