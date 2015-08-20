using System;

namespace TradeAndTravel
{
    class ExtendedInteractionManager : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    return item = new Weapon(itemNameString, itemLocation);
                case "wood":
                    return item = new Wood(itemNameString, itemLocation);
                case "iron":
                    return item = new Iron(itemNameString, itemLocation);
                default:
                    return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            }
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            switch (locationTypeString)
            {
                case "mine":
                    return new Mine(locationName);
                case "forest":
                    return new Forest(locationName);
                default:
                    return base.CreateLocation(locationTypeString, locationName);
            }
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    var itemName = commandWords[2];
                    HandleGatherInteraction(actor, itemName);
                    break;
                case "craft":
                    var itemType = commandWords[2];
                    itemName = commandWords[3];
                    HandleCraftInteraction(actor, itemType, itemName);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            switch (personTypeString)
            {
                case "merchant":
                    return new Merchant(personNameString, personLocation);
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
        }

        private void HandleCraftInteraction(Person actor, string itemType, string itemName)
        {
            Item newItem;
            if (itemType == "weapon" && actor.InventorryContains(ItemType.Wood, ItemType.Iron))
            {
                newItem=new Weapon(itemName);
                this.AddToPerson(actor, newItem);
            }
            else if (itemType == "armor" && actor.InventorryContains(ItemType.Iron))
            {
                newItem =new Armor(itemName);
                this.AddToPerson(actor, newItem);
            }
        }

        private void HandleGatherInteraction(Person actor, string itemName)
        {
            if (actor.Location is IGatheringLocation)
            {
                var location = actor.Location as IGatheringLocation;
                if (actor.InventorryContains(location.RequiredItem))
                {
                    var gatheredItem = location.ProduceItem(itemName);
                    this.AddToPerson(actor, gatheredItem);
                }
            }
        }
    }
}
