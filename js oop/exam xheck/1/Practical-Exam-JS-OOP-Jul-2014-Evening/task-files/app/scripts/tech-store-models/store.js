define(['tech-store-models/item'], function (Item) {
    'use strict';
    var Store;
    Store = (function () {
        function Store(name) {
            if(name.length < 6 || name.length > 30){
                throw {message: 'Invalid store name! Must be between 6-30 characters!'}
            }

            this._name = name;
            this._items = [];
        }

        function sortLexicographically(items){
            return items.sort(function(item1, item2){
                return item1._name.localeCompare(item2._name);
            });
        }

        function getItemsByType(types){
            var selectedItems = [],
                i,
                j,
                itemsCount =  this._items.length;

            for (i = 0; i < types.length; i += 1) {
                for (j = 0; j < itemsCount; j += 1) {
                    if(this._items[j]._type === types[i]){
                        selectedItems.push(this._items[j]);
                    }
                }
            }

            return selectedItems;
        }

        Store.prototype = {
            addItem: function(item){
                if(item instanceof Item){
                    this._items.push(item);
                }
                else{
                    throw {message: 'Invalid item passed!'}
                }
                return this;
            },

            getAll: function(){
                return sortLexicographically.call(this, this._items);
            },

            getSmartPhones: function(){
                var smartPhones = getItemsByType.call(this, ['smart-phone']);
                return sortLexicographically.call(this, smartPhones);
            },

            getMobiles: function(){
                var mobiles = getItemsByType.call(this, ['smart-phone', 'tablet']);
                return sortLexicographically.call(this, mobiles);
            },

            getComputers: function(){
                var computer = getItemsByType.call(this, ['pc', 'notebook']);
                return sortLexicographically.call(this, computer);
            },

            filterItemsByType: function(filterType){
                switch (filterType){
                    case 'accessory':break;
                    case 'smart-phone':break;
                    case 'notebook':break;
                    case 'pc':break;
                    case 'tablet':break;
                    default: throw{message: 'Invalid item type!'}
                }

                var items = getItemsByType.call(this, [filterType]);
                return sortLexicographically.call(this, items);
            },

            filterItemsByPrice: function (options){
                var max , min,
                    matchingItems = [],
                    itemsCount = this._items.length,
                    i;

                if(options){
                    max = options.max || Infinity;
                    min = options.min || 0;
                }
                else{
                    max = Infinity;
                    min = 0;
                }

                for (i = 0; i < itemsCount; i += 1) {
                    if(this._items[i].price > min && this._items[i].price < max){
                        matchingItems.push(this._items[i]);
                    }
                }

                return matchingItems.sort(function(item1, item2){
                    return item1.price - item2.price;
                });
            },

            countItemsByType: function(){
                var typesCount = [],
                    itemCount = this._items.length,
                    currType,
                    i;

                for (i = 0; i < itemCount; i++) {
                    currType = this._items[i]._type;

                    if(typesCount[currType]){
                        typesCount[currType] ++;
                    }
                    else{
                        typesCount[currType] = 1;
                    }
                }

                return typesCount;
            },

            filterItemsByName: function(partOfName){
                var filteredItems = [],
                    itemsCount = this._items.length,
                    searchPart = partOfName.toLowerCase(),
                    currItem,
                    itemName,
                    j;

                for (j = 0; j < itemsCount ; j++) {
                    currItem = this._items[j];
                    itemName = currItem._name.toLowerCase();

                    if(itemName.indexOf(searchPart) > -1){
                        filteredItems.push(currItem);
                    }
                }

                return sortLexicographically.call(this, filteredItems);
            }
        };

        return Store;
    })();
    return Store;
});