define([], function () {
    var Store = (function () {
        function sortingMethodByName(a, b) { //local compare
            //return firstItem.name - secondItem.name;
            var nameA = a.name.toLowerCase(),
                nameB = b.name.toLowerCase()
            if (nameA < nameB) //sort string ascending
                return -1
            if (nameA > nameB)
                return 1
            return 0 //default return value (no sorting)

        }

        function sortingMethodByPrice(firstItem, secondItem) {
            return firstItem.price / 1 - secondItem.price / 1;
        }

        function Store(name) {
            this.name = name;
            this._items = [];
        }

        Store.prototype = {
            addItem: function (item) {
                this._items.push(item);
                return this;
            },
            getAll: function () {
                var sortedItems = this._items.sort(sortingMethodByName);
                return sortedItems;
            },
            getSmartPhones: function () {
                var allItems = this.getAll(); //!!! check if right to be this ot Store
                var smartPhones = [];
                for (var i = 0; i < allItems.length; i++) {
                    if (allItems[i].type == 'smart-phone') {
                        smartPhones.push(allItems[i]);
                    }

                }
                return smartPhones;
            },
            getMobiles: function () {
                var allItems = this.getAll(); //!!! check if right to be this ot Store
                var mobiles = [];
                for (var i = 0; i < allItems.length; i++) {
                    if (allItems[i].type == 'smart-phone' || allItems[i].type == 'tablet') {
                        mobiles.push(allItems[i]);
                    }

                }
                return mobiles;
            },
            getComputers: function () {
                var allItems = this.getAll(); //!!! check if right to be this ot Store
                var pcs = [];
                for (var i = 0; i < allItems.length; i++) {
                    if (allItems[i].type == 'pc' || allItems[i].type == 'notebook') {
                        pcs.push(allItems[i]);
                    }

                }
                return pcs;
            },
            filterItemsByType: function (filterItemsByType) {
                var allItems = this.getAll(); //!!! check if right to be this ot Store
                var filteredItems = [];
                for (var i = 0; i < allItems.length; i++) {
                    if (allItems[i].type === filterItemsByType) {
                        filteredItems.push(allItems[i]);
                    }

                }
                return filteredItems;
            },
            filterItemsByPrice: function (range) {
                if (!range) {
                    var sortedPrices = this._items.sort(sortingMethodByPrice);
                    return sortedPrices;
                }
                var _min = range.min || 0;
                var _max = range.max || Number.MAX_VALUE;
                var sortedPrices = this._items.sort(sortingMethodByPrice);

                //return sortedPrices.slice(_min, _max);
                var rangePrices = [];
                for (var i = 0; i < sortedPrices.length; i++) {
                    if (sortedPrices[i].price <= _max && sortedPrices[i].price >= _min) {
                        rangePrices.push(sortedPrices[i]);
                    }

                }
                return rangePrices;
            },
            filterItemsByName: function (partOfName) {

                var allItems = this.getAll()
                var itemsFilteredByName = [];
                for (var i = 0; i < allItems.length; i++) {
                    //console.log((allItems[i].name).indexOf(partOfName));
                    if ((allItems[i].name.toLowerCase()).indexOf(partOfName.toLowerCase()) > 0) {
                        itemsFilteredByName.push(allItems[i]);
                    }

                }
                return itemsFilteredByName;
            },
            countItemsByType: function () {

                var allItems = this.getAll();
                var _countItemsByType = [];
                for (var i = 0; i < allItems.length; i++) {
                    if (_countItemsByType.indexOf(allItems[i].type > 0)) {
                        _countItemsByType[(allItems[i].type)] = 1;
                    } else {
                        _countItemsByType[(allItems[i].type)] = _countItemsByType[(allItems[i].type)] + 1;
                    }

                }
                return _countItemsByType;
            }



        }

        // Prototype

        return Store;
    }());
    return Store;
});