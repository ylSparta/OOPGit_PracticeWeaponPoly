using System;
using System.Collections.Generic;

namespace WeaponPolymorphism
{
    public abstract class Weapon
    {
        protected string _brand;

        public Weapon() { }

        public Weapon(string brand)
        {
            _brand = brand;
        }

        public string Shoot()
        {
            return null;
        }

        public override string ToString()
        {
            return $"This is a {_brand}";

        }


        static void Main(string[] args)
        {
            List<Weapon> Inventory = new List<Weapon>();
            WaterPistol wap = new WaterPistol("Meg The Stallion");
            Inventory.Add(wap);
            if (Inventory.Contains(wap))
            {
                Console.WriteLine(wap.Shoot());
            }
            LaserGun zap = new LaserGun("Heat Ray 3000");
            Inventory.Add(zap);
            if (Inventory.Contains(zap))
            {
                Console.WriteLine(zap.Shoot());
            }

            foreach (var item in Inventory)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
