using System.Collections.Generic;
namespace TradeAndTravel
{
    class Weapon:Item
    {
        const int GeneralWeaponValue = 10;

        public Weapon(string name, Location location = null)
            : base(name, Weapon.GeneralWeaponValue, ItemType.Weapon, location)
        {
        }
    }
}
