define(['tech-store-models/item'], function (Item) {
    var Store;
    Store = (function () {
        var nameMinLen = 6,
            nameMaxLen = 30;

        function Store(name) {
            if (!(typeof (name) == 'string')) {
                throw {
                    message: 'Store name must be string'
                }
            }
            var nameLength = name.length;
            if (nameLength < nameMinLen || nameLength > nameMaxLen) {
                throw {
                    message: 'Invalid store name length!'
                }
            }

            this.name = name;
            this._items = [];
        }

        function compareByName(item1, item2) {
            if (item1.name.toLowerCase() < item2.name.toLowerCase()) {
                return -1;
            }
            if (item1.name.toLowerCase() > item2.name.toLowerCase()) {
                return 1;
            }
            return 0;
        }

        function compareByPrice(item1, item2) {
            if (item1.price < item2.price) {
                return -1;
            }
            if (item1.price > item2.price) {
                return 1;
            }
            return 0;
        }

        function filterByType(types) {
            //types = ['type1', ...]
            var filteredItems = this._items.filter(function (item) {
                return types.indexOf(item.type) != -1;
            });

            return filteredItems;
        }

        function filterByPrice(min, max) {
            var filteredItems = this._items.filter(function (item) {
                return min <= item.price && item.price <= max;
            });

            return filteredItems;
        }

        Store.prototype.addItem = function (item) {
            if (!(item instanceof Item)) {
                throw {
                    message: 'Argument is not instance of Item!'
                }
            }

            this._items.push(item);
            return this;
        }

        Store.prototype.getAll = function () {
            var itemsCopy = this._items.slice(0);
            itemsCopy.sort(compareByName);

            return itemsCopy;
        }

        Store.prototype.getSmartPhones = function () {
            var smartPhones = filterByType.call(this, ['smart-phone']);
            smartPhones.sort(compareByName);
            return smartPhones;
        }

        Store.prototype.getMobiles = function () {
            var mobiles = filterByType.call(this, ['smart-phone', 'tablet']);
            mobiles.sort(compareByName);
            return mobiles;
        }

        Store.prototype.getComputers = function () {
            var computers = filterByType.call(this, ['pc', 'notebook']);
            computers.sort(compareByName);
            return computers;
        }

        Store.prototype.filterItemsByType = function (filterType) {
            var itemsByType = filterByType.call(this, [filterType]);
            itemsByType.sort(compareByName);
            return itemsByType;
        }

        Store.prototype.filterItemsByPrice = function (options) {
            var min, max;
            if (!options) {
                min = 0;
                max = Number.MAX_VALUE;
            } else {
                min = options.min || 0;
                max = options.max || Number.MAX_VALUE;
            }
          
            var filteredItems = filterByPrice.call(this, min, max);
            filteredItems.sort(compareByPrice);

            return filteredItems;
        }

        Store.prototype.countItemsByType = function () {
            var result = {};
            for (var i = 0, len = this._items.length; i < len; i++) {
                var item = this._items[i];
                if (!result[item.type]) {
                    result[item.type] = 1;
                } else {
                    result[item.type]++;
                }
            }

            return result;
        }

        Store.prototype.filterItemsByName = function (partOfName) {
            var partOfNameToLower = partOfName.toLowerCase();
            var itemsByName = this._items.filter(function (item) {
                var name = item.name.toLowerCase();
                return name.indexOf(partOfNameToLower) != -1;
            });
            itemsByName.sort(compareByName);

            return itemsByName;
        }

        return Store;
    })();

    return Store;
})