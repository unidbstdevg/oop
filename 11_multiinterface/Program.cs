using System;

namespace _11_multiinterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Amphibia am = new Amphibia();
            am.StartEngine();

            ICar car1 = am;
            car1.StartEngine();

            IBoat boat1 = am;
            boat1.StartEngine();
        }
    }
}
