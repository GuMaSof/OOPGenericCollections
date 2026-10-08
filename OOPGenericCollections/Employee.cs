using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGenericCollections
{
    internal class Employee
    {
        //Properties for the objects.
        private string id;
        private string name;
        private string gender;
        private int salary;
        //Managing access to properties.
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
