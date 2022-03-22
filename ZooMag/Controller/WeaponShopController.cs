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
    }
}
