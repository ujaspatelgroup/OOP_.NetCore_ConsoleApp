using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp.NetCore
{
    class Employee : Person
    {

        public Employee(string Name, Address Residence, string email, double salary, DateTime hiredate) : base(Name, Residence, email)
        {
            this.salary = salary;
            this.hiredate = hiredate;

        }

        [Range(2000, 8000)]
        private double salary { set; get; }

        private DateTime hiredate { set; get; }

        public override string ToString()
        {
            return  $" {base.ToString()} Class Employee salary is {salary} and hire date is { hiredate.Date}.";
        }
    }
}
