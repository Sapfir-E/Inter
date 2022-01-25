using System;
using System.Collections.Generic;
using System.Text;

namespace Inter
{
    class Pistolet : IWeapon
    {
        public int Yron => 3;

        public void Zvuk()
        {
            Console.WriteLine("ПИУ!!");
        }
    }
}
