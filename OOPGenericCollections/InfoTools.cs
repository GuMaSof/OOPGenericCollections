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
    }
}
