using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.NetCore
{
    class Address
    {
        public Address(string Address1, string Address2, string City)
        {
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.City = City;
        }

        private string Address1 { get; set; }
        private string Address2 { get; set; }
        private string City { get; set; }

        public override string ToString()
        {
            return $"Class Address {Address1} {Address2} {City}.";
        }

    }
}
