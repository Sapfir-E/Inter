using System;
using System.Collections.Generic;
using System.Text;

namespace Inter
{
    class Vintovka : IWeapon
    {
        public int Yron => 19;

        public void Zvuk()
        {
            Console.WriteLine("БAAХХХ!!!! ");
        }
    }
}
