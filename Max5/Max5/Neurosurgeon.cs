using System;
using System.Collections.Generic;
using System.Text;

namespace Max5
{
    class Neurosurgeon:Surgeon
    {
        string name;
        int salary;

        public Neurosurgeon(string name, int salary, string university) : base(university)
        {
            this.name = name;
            this.salary = salary;
        }

        public string get_name()
        {
            return name;
        }

        public void set_name(string name)
        {
            this.name = name;
        }

        public int get_salary()
        {
            return salary;
        }

        public void set_salary(int salary)
        {
            this.salary = salary;
        }
    }
}
