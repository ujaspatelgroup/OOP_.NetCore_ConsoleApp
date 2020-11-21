using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.NetCore
{
    public enum rank { AssistProf, AssocProf }
    class Professor : Employee
    {
        public Professor(string Name, Address Residence, string email, double salary, DateTime hiredate, double hours, rank rank) :base(Name, Residence, email, salary, hiredate)
        {
            this.hours = hours;
            this.rank = rank;
        }
        private double hours { get; set; }

        private rank rank { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} Class Professor Hours: { hours} Rank: {rank}.";
        }
    }
}
