using System;
using System.Collections.Generic;
using System.Text;

namespace Inter
{
    class Avtomat : IWeapon
    {
        public int Yron => 7;

        public void Zvuk()
        {
            Console.WriteLine("ПУХ!!!!");
        }
    }
}
