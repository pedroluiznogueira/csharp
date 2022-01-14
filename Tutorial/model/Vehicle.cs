using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.model
{
    abstract class Vehicle
    {
        public abstract void present();

        public void print()
        {
            Console.WriteLine("hey");
        }
    }
}
