using System;

namespace Inter
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeapon pistol = new Pistolet();
            IWeapon avtoma = new Avtomat();
            IWeapon vintov = new Vintovka();

            pistol.Otobrazenie();
            pistol.Zvuk();
            avtoma.Otobrazenie();
            avtoma.Zvuk();
            vintov.Otobrazenie();
            vintov.Zvuk();
        }
    }
}
