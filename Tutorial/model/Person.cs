using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Person
    {
        private string name;

        // property Name handles accessing and changing name attribute value
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
