define(function () {
    var Store = (function () {
        function Store(name) {
            this._name = name;
            this._items = [];
        };

        function sortByAlphabet(array) {
            array.sort(function (item1, item2) {
                return item1._name.localeCompare(item2._name);
            });

            return array;
        }

        function sortByPrice(array) {
            array.sort(function (item1, item2) {
                return item1._price - item2._price;
            });

            return array;
        }

        Store.prototype.addItem = function (item) {
            this._items.push(item);
            return this;
        }

        Store.prototype.getAll = function () {
            return sortByAlphabet(this._items);
        }

        Store.prototype.getSmartPhones = function () {
            var smartphones = [],
                sortedSmartphones = [];

            this._items.forEach(function (item) {
                if (item._type === 'smart-phone') {
                    smartphones.push(item);
                }

                sortedSmartphones = sortByAlphabet(smartphones);
            });

            return sortedSmartphones;
        }

        Store.prototype.getMobiles = function () {
            var mobiles = [],
                sortedMobiles = [];

            this._items.forEach(function (item) {
                if (item._type === 'smart-phone' || item._type === 'tablet') {
                    mobiles.push(item);
                }

                sortedMobiles = sortByAlphabet(mobiles);
            });

            return sortedMobiles;
        }

        Store.prototype.getComputers = function () {
            var computers = [],
                sortedComputers = [];

            this._items.forEach(function (item) {
                if (item._type === 'pc' || item._type === 'notebook') {
                    computers.push(item);
                }

                sortedComputers = sortByAlphabet(computers);
            });

            return sortedComputers;
        }

        Store.prototype.filterItemsByPrice = function (options) {
            var sortedItems = [],
                items = [];

            if (!options) {
                this._items.forEach(function (item) {
                    items.push(item)
                });

                sortedItems = sortByPrice(items);
            } else {
                this._items.forEach(function (item) {
                    var min = options.min || 0,
                        max = options.max || Number.MAX_VALUE;

                    if (min + 1 < item._price && item._price < max - 1) {
                        items.push(item)
                    }
                });

                sortedItems = sortByPrice(items);
            }

            return sortedItems;
        }

        Store.prototype.filterItemsByType = function (filterType) {
            var filteredItems = [],
                sortedItems = [];

            this._items.forEach(function (item) {
                if (item._type === filterType) {
                    filteredItems.push(item);
                }

                sortedItems = sortByPrice(filteredItems);
            });

            return sortedItems;
        }

        Store.prototype.filterItemsByName = function (string) {
            var filteredItems = [],
                sortedItems = [];

            this._items.forEach(function (item) {
                if (item._name.toLowerCase().indexOf(string) !== -1) {
                    filteredItems.push(item);
                }

                sortedItems = sortByPrice(filteredItems);
            });

            return sortedItems;
        };

        Store.prototype.countItemsByType = function () {
            var accCount = 0,
                smartphoneCount = 0,
                notebookCount = 0,
                pcCount = 0,
                tabletCount = 0,
                array = [];
                //arrayOfTypes = [];

            //Array.prototype.contains = function (needle) {
            //    for (i in this) {
            //        if (this[i] === needle) return true;
            //    }
            //    return false;
            //}

            //this._items.forEach(function (item) {
            //    if (!arrayOfTypes.contains(item._type)) {
            //        arrayOfTypes.push(item._type);
            //    }
            //});


            this._items.forEach(function (item) {
                if (item._type === 'accessory') {
                    accCount += 1;
                } else if (item._type === 'smart-phone') {
                    smartphoneCount += 1;
                }
                else if (item._type === 'notebook') {
                    notebookCount += 1;
                }
                else if (item._type === 'pc') {
                    pcCount += 1;
                }
                else if (item._type === 'tablet') {
                    tabletCount += 1;
                }
            });

            array['accessory'] = accCount;
            array['smart-phone'] = smartphoneCount;
            array['notebook'] = notebookCount;
            array['pc'] = pcCount;
            array['tablet'] = tabletCount;

            return array;
        }

        return Store;
    }());

    return Store;
});