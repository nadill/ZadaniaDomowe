using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie8
{
    class Customer
    {
        private string fname;
        private string lname;
        private int priority;
        public int Priority { get; }

        public Customer( string _fname, string _lname, int _priority) {

            fname = _fname;
            lname = _lname;
            priority = (_priority > 3) ? 3 : _priority;
            Priority = priority;
        }

        public string PrintCustomerData()
        {
            string customerData = $"{fname} {lname}";
            return customerData;
        }
    }
}
