using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooMag.Model;

namespace ZooMag.Controller
{
    public class WeaponShopController
    {
        public List<Weapon> GetWeapons()
        {
            using (WeaponsDBEntities db = new WeaponsDBEntities())
            {
                return db.Weapons.ToList();
            }
        }

        public void Create(Weapon weapon)
        {
            using (WeaponsDBEntities db = new WeaponsDBEntities())
            {
                var weapons = db.Weapons.ToList();
                if (weapons.First() == null)
                {
                    weapon.Id = 0;
                }
                else
                {
                    weapon.Id = weapons.Last().Id + 1;
                }
                db.Weapons.Add(weapon);
                db.SaveChanges();

            }
        }
    }
}
