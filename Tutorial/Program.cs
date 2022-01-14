using System.Linq;
using Tutorial.model;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myCar = new Car();
            myCar.present();

            Car myOtherCar = new Car();
            myOtherCar.present();
        }
    }
}