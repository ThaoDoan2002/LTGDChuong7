using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
    [Serializable]
    public class Employee
    {
        private string name;
        private int age;
        private string address;

        public Employee() { }
        public Employee(string name, int age, string adress)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
    }
}
