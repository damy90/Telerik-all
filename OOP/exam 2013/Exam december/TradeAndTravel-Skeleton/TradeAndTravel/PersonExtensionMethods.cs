using System.Linq;
namespace TradeAndTravel
{
    public static class PersonExtensionMethods
    {
        public static bool InventorryContains(this Person actor, params ItemType[] itemTypes)
        {
            foreach (var itemType in itemTypes)
            {
                if (!actor.ListInventory().Any(x => x.ItemType == itemType))
                {
                    return false;
                }
            }


            return true;
        }
    }
}
