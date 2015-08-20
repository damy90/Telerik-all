using System;
using System.Linq;
using System.Collections.Generic;
using Models.Gear.Weapons;
using Models.Gear.Items;
using Models.Interfaces;
using System.Text;
using System.Globalization;

namespace Models.Gear
{
    public class ItemShop
    {
        public GearInStock gearInStock;

        private IEnumerable<IWeapon> weapon = new IList<IWeapon>();
        private IEnumerable<IItem> item = new IList<IItem>();
        public ItemShop(IEnumerable<IGear> gearInStock)
        {
            this.gearInStock = new GearInStock(weapon,item);
        }
        
        public Weapon WeaponUpgrade(Weapon weapon)
        {
            weapon.AttackPoints += 50;
            if(weapon.AttackPoints==100)
            {
                weapon.AttackPoints = 100;
            }
            return weapon;
        }

        public Item ItemUpgrade(Item item)
        {
            item.DefensePoints += 50;
            if(item.DefensePoints>100)
            {
                item.DefensePoints = 100;
            }
            return item;
        }

        public override string ToString()
        {
            StringBuilder gearInfo = new StringBuilder();
            foreach (var item in this.weapon)
            {
                gearInfo.AppendFormat(item.ToString());
            }
            return gearInfo.ToString();
        }

       
    }
}
