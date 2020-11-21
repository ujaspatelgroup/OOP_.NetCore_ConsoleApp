using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.NetCore
{
    class Student : Person
    {
        
        public Student(string Name, Address Residence, string email) : base(Name,Residence,email)
        {

        }


        public override string ToString()
        {
            return $"{base.ToString()} Class name Student.";
        }
    }
}
