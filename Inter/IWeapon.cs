using System;
using System.Collections.Generic;
using System.Text;

namespace Inter
{
    interface IWeapon
    {
        int Yron { get; }

        void Otobrazenie()
        {
            Console.WriteLine($"Дамаг : {Yron}");
        }

        void Zvuk();
    }
}
