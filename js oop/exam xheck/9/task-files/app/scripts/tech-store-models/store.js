define(['tech-store-models/item'], function (Item) {
    'use strict';
    var Store;

    Store = (function () {
        function Store(name) {
            this.name = name;
            this.stock = [];
        }

        Store.prototype = {
            addItem: function (item) {
                if (!(item instanceof Item)) {
                    throw {
                        message: 'Not a valid item!'
                    };
                }
                this.stock.push(item);

                return this;
            },

            getAll: function () {
                return this.stock.sort(function (a, b) {
                    return a.name.localeCompare(b.name);
                });
            },

            getSmartPhones: function () {
                var len = this.stock.length;
                var smartPhones = [];

                for (var i = 0; i < len; i++) {
                    var currentItem = this.stock[i];

                    if (currentItem.type === 'smart-phone') {
                        smartPhones.push(currentItem);
                    }
                }

                return smartPhones.sort(function (a, b) {
                    return a.name.localeCompare(b.name);
                });             
            },

            getMobiles: function () {
                var len = this.stock.length;
                var mobiles = [];

                for (var i = 0; i < len; i++) {
                    var currentItem = this.stock[i];

                    if (currentItem.type === 'smart-phone' ||
                        currentItem.type === 'tablet') {
                        mobiles.push(currentItem);
                    }
                }

                return mobiles.sort(function (a, b) {
                    return a.name.localeCompare(b.name);
                });
            },

            getComputers: function () {
                var len = this.stock.length;
                var computers = [];

                for (var i = 0; i < len; i++) {
                    var currentItem = this.stock[i];

                    if (currentItem.type === 'pc' ||
                        currentItem.type === 'notebook') {
                        computers.push(currentItem);
                    }
                }

                return computers.sort(function (a, b) {
                    return a.name.localeCompare(b.name);
                });
            },

            filterItemsByType: function (filterType) {
                var len = this.stock.length;
                var filterItems = [];

                for (var i = 0; i < len; i++) {
                    var currentItem = this.stock[i];

                    if (currentItem.type === filterType) {
                        filterItems.push(currentItem);
                    }
                }

                return filterItems.sort(function (a, b) {
                    return a.name.localeCompare(b.name);
                });
            },

            countItemsByType: function () {
                var len = this.stock.length;
                var itemsByType = {};

                for (var i = 0; i < len; i++) {
                    var currentItem = this.stock[i];
                    var currentItemType = currentItem.type;

                    if (itemsByType[currentItemType] === undefined) {
                        itemsByType[currentItemType] = 0;
                    }
                    else {
                        continue;
                    }

                    for (var j = 0; j < len; j++) {
                        if (this.stock[j].type === currentItemType) {
                            itemsByType[currentItemType]++;
                        }
                    }
                }

                return itemsByType;
            },

            filterItemsByPrice: function (options) {
                var min,
                    max;

                if (arguments.length === 0) {
                    min = 0;
                    max = Number.MAX_VALUE;
                }
                else {
                    min = options.min || 0;
                    max = options.max || Number.MAX_VALUE;
                }
                

                var len = this.stock.length;
                var filterItems = [];

                for (var i = 0; i < len; i++) {
                    var currentItem = this.stock[i];
                    var price = currentItem.price;

                    if (price > min &&
                        price < max) {
                        filterItems.push(currentItem);
                    }
                }

                return filterItems.sort(function (a, b) {
                    return a.price - b.price;
                });

            },



            // – returns a collection of only the items in stock that have a name containing partOfName,
            //sorted lexicographically by the name of the items. The search should be performed case insensitive
            filterItemsByName: function (partOfName) {
                var subString = partOfName.toLowerCase();
                var len = this.stock.length;
                var filterItems = [];

                for (var i = 0; i < len; i++) {
                    var currentItem = this.stock[i];
                    var currentItemName = currentItem.name.toLowerCase();

                    if (currentItemName.indexOf(subString) > -1) {
                        filterItems.push(currentItem);
                    }
                }

                return filterItems.sort(function (a, b) {
                    return a.name.localeCompare(b.name);
                });
            }
        };

        return Store;
    })();

    return Store;
});