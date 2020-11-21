using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.NetCore
{
    public enum designation { OfficeAssistance, Clerk }
    class Staff : Employee
    {
        
        public Staff(string Name, Address Residence, string email, double salary, DateTime hiredate, designation designation) :base(Name,Residence,email,salary,hiredate)
        {
            this.designation = designation;
           
        }
        private designation designation { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} Class Satff Designation: {designation}.";
        }
    }
}
