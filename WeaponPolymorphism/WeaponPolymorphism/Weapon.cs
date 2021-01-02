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

        public virtual string Shoot()
        {
            return $"Shooting a {ToString()}";
        }


        static void Main(string[] args)
        {
            List<IShootable> Inventory = new List<IShootable>();
            WaterPistol wap = new WaterPistol("Meg The Stallion");
            Inventory.Add(wap);
            LaserGun zap = new LaserGun("Heat Ray 3000");
            Inventory.Add(zap);
            foreach (var item in Inventory)
            {   
                Console.WriteLine(item.Shoot());
            }


        }


    }
}
