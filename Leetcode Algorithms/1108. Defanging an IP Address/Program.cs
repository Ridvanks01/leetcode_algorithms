using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1108.Defanging_an_IP_Address
{
    internal class Program
    {
        public string DefangIPaddr(string address)
        {
            address = address.Replace(".", "[.]");

            return address;
        }
    }
}
