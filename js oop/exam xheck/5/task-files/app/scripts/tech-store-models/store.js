define(function () {
    var Store = (function () {
        var Store = function () {
            this._items = [];
        };

        //addItem
        Store.prototype.addItem = function (item) {
            this._items.push(item);
            return this;
        };

        //getAll
        Store.prototype.getAll = function () {
            this._items.sort(function (a, b) {
                return a.name.localeCompare(b.name);
            });
            var allItems = this._items.slice(0);
            return allItems;
        };

        //getSmartPhones
        Store.prototype.getSmartPhones = function () {
            this._items.sort(function (a, b) {
                return a.name.localeCompare(b.name);
            });
            var allSmartPhones = this._items.filter(function (element) {
                return element.type === 'smart-phone';
            })
            return allSmartPhones;
        };

        //getMobiles
        Store.prototype.getMobiles = function () {
            this._items.sort(function (a, b) {
                return a.name.localeCompare(b.name);
            });
            var allMobiles = this._items.filter(function (element) {
                return (element.type === 'smart-phone' || element.type === 'tablet');
            })
            return allMobiles;
        };

        //getComputers
        Store.prototype.getComputers = function () {
            this._items.sort(function (a, b) {
                return a.name.localeCompare(b.name);
            });
            var allComputers = this._items.filter(function (element) {
                return (element.type === 'pc' || element.type === 'notebook');
            })
            return allComputers;
        };

        //filterItemsByPrice
        Store.prototype.filterItemsByPrice = function (params) {
            var minPrice = 0;
            var maxPrice = Number.MAX_VALUE;

            if (typeof params != 'undefined') {
                minPrice = params.min || 0;
                maxPrice = params.max || Number.MAX_VALUE;
            }

            this._items.sort(function (a, b) {
                return parseFloat(a.price) - parseFloat(b.price);
            });
            var itemsFilteredByName = this._items.filter(function (element) {
                return (element.price > minPrice && element.price < maxPrice);
            })
            return itemsFilteredByName;
        };

        //filterItemsByType
        Store.prototype.filterItemsByType = function (type) {
            var elementType = type;
            this._items.sort(function (a, b) {
                return a.name.localeCompare(b.name);
            });
            var allFilteredItemsByType = this._items.filter(function (element) {
                return element.type === elementType;
            })
            return allFilteredItemsByType;
        };

        //filterItemsByName
        Store.prototype.filterItemsByName = function (name) {
            var elementName = name;
            this._items.sort(function (a, b) {
                return a.name.localeCompare(b.name);
            });
            var allFilteredItemsByName = this._items.filter(function (element) {
                return (element.name.toLowerCase().indexOf(elementName) != -1);
            })
            return allFilteredItemsByName;
        };

        //countItemsByType
        Store.prototype.countItemsByType = function () {
            var array = this._items,
                associativeArray = [],
                accessoryType = 'accessory',
                accessoryCount = 0,
                smartphoneType = 'smart-phone',
                smartphoneCount = 0,
                notebookType = 'notebook',
                notebookCount = 0,
                pcType = 'pc',
                pcCount = 0,
                tabletType = 'tablet',
                tabletCount = 0;

            for (var i = 0; i < array.length; i++) {
                if (array[i].type == accessoryType)
                {
                    accessoryCount++;

                }
                if (array[i].type == smartphoneType)
                {
                    smartphoneCount++;
                }
                if (array[i].type == notebookType)
                {
                    notebookCount++;
                }
                if (array[i].type == pcType)
                {
                    pcCount++;
                }
                if (array[i].type == tabletType)
                {
                    tabletCount++;
                }
            }
            associativeArray.push({type: accessoryType,count: accessoryCount});
            associativeArray.push({type: smartphoneType,count: smartphoneCount});
            associativeArray.push({type: notebookType,count: notebookCount});
            associativeArray.push({type: pcType,count: pcCount});
            associativeArray.push({type: tabletType,count: tabletCount});

            return associativeArray;
        };

        return Store;
    }());
    return Store;
});