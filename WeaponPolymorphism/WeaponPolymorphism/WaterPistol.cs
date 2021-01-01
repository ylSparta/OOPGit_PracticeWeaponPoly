using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponPolymorphism
{
    public class WaterPistol: Weapon
    {
        public WaterPistol() { }

        public WaterPistol(string brand) 
        {
            _brand = brand;
        }


        public new string Shoot()
        {
            return $"Splash!! {base.Shoot()}";
        }
    }
}
