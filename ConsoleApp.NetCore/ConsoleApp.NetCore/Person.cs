using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.NetCore
{
    class Person
    {
        public Person(string Name, Address Residence, string email)
        {
            this.Name = Name;
            this.Residence = Residence;
            this.email = email;
        }

        public string Name { get; set; }

        private Address Residence { get; set; }

        private string email { get; set; }
        public override string ToString()
        {
            return $"Class Person Name: {Name} Address: {Residence} Email: { email}.";
        }
    }
}
