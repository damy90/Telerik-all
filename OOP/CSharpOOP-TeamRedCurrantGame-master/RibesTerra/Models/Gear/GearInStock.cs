using Models.Extensions;
using Models.Gear.Items;
using Models.Gear.Weapons;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Gear
{
    public struct GearInStock
    {
       
        private IEnumerable<IWeapon> weapon;
        private IEnumerable<IItem> item;


        public GearInStock(IEnumerable<IWeapon> weapon, IEnumerable<IItem> item)
        {
            this.weapon = weapon;
            this.item = item;
        }

        
    }
}
