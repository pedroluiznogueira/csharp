using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.interfaces;

namespace Tutorial.model
{
    class Car : Vehicle, IBestVehicle
    {
        public void greet()
        {
            Console.WriteLine("Hey I'm a best vehicle");
        }

        public override void present()
        {
            Console.WriteLine("Presenting myself");    
        }
    }
}
