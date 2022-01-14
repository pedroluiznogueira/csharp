using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.model
{
    class Car : Vehicle
    {
        public override void present()
        {
            Console.WriteLine("I'm a car");
        }
    }
}
