using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponPolymorphism
{
    public class LaserGun: Weapon
    {
        public LaserGun() { }

        public LaserGun(string brand)
        { 
            _brand = brand; 
        }

        public new string Shoot()
        {
            return $"Zing!! {base.Shoot()}";
        }

    }
}
