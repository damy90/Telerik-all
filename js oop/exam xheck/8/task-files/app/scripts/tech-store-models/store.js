(function(){
    define(['tech-store-models/item'], function(Item) {
        var Store = (function(){
            function Store(name) {
                this.name = this.setName(name);
                this.items = [];
            }

            Store.prototype = {
                setName: function(name) {
                    if (name && name.hasOwnProperty('length') && name.length >=6 && name.length <= 30) {
                        return name;
                    } else throw new Error("Name must be between 6 and 30 characters long.");
                },

                addItem: function(item) {
                    if (!item instanceof Item) {
                        throw new Error("Cannot add invalid item.");
                    } else {
                        this.items.push(item);
                    }
                    return this;
                },

                getAll: function() {
                    return this.items.sort(this.sortLexicographically('name'));
                },

                getSmartPhones: function() {
                    var smartPhones = [], i, length = this.items.length, items = this.items;
                    for (i = 0; i < length; i++) {
                        if (items[i]['type'] === 'smart-phone') {
                            smartPhones.push(items[i]);
                        }
                    }
                    return smartPhones.sort(this.sortLexicographically('name'));
                },

                getMobiles: function() {
                    var mobiles = [], i, length = this.items.length, items = this.items;
                    for (i = 0; i < length; i++) {
                        if (items[i]['type'] === 'smart-phone' || items[i]['type'] === 'tablet') {
                            mobiles.push(items[i]);
                        }
                    }
                    return mobiles.sort(this.sortLexicographically('name'));
                },

                getComputers: function() {
                    var computers = [], i, length = this.items.length, items = this.items;
                    for (i = 0; i < length; i++) {
                        if (items[i]['type'] === 'pc' || items[i]['type'] === 'notebook') {
                            computers.push(items[i]);
                        }
                    }
                    return computers.sort(this.sortLexicographically('name'));
                },

                filterItemsByType: function(filterType) {
                    var filteredItems = [], i, length = this.items.length, items = this.items;
                    for (i = 0; i < length; i++) {
                        if (items[i]['type'] === filterType) {
                            filteredItems.push(items[i]);
                        }
                    }
                    return filteredItems.sort(this.sortLexicographically('name'));
                },

                filterItemsByPrice: function(options) {
                    var minRange, maxRange, items = this.items, filteredItems = [], length = this.items.length, i;

                    if (options && options.hasOwnProperty('min')) minRange = options['min'];
                    else minRange = 0;
                    if (options && options.hasOwnProperty('max')) maxRange = options['max'];
                    else maxRange = 9007199254740992;

                    for (i = 0; i < length; i++) {
                        if (items[i]['price'] >= minRange && items[i]['price'] <= maxRange) {
                            filteredItems.push(items[i]);
                        }
                    }

                    return filteredItems.sort(this.sortPriceAscending);
                },

                countItemsByType: function() {
                    var filteredItems = [], i, length = this.items.length, items = this.items;

                    for (i = 0; i < length; i++) {
                        var currentType = items[i]['type'];
                        if (!filteredItems[currentType]) filteredItems[currentType] = 0;
                        filteredItems[currentType]++;
                    }

                    return filteredItems;
                },

                filterItemsByName: function(partOfName) {
                    var filteredItems = [], i, length = this.items.length, items = this.items;

                    for (i = 0; i < length; i++) {
                        if (items[i]['name'].toLowerCase().indexOf(partOfName.toLowerCase()) != -1) {
                            filteredItems.push(items[i]);
                        }
                    }

                    return filteredItems.sort(this.sortLexicographically('name'));
                },

                sortLexicographically: function(property) {
                    return function(a,b){ return a[property].localeCompare(b[property]); };
                },

                sortPriceAscending: function(a, b){
                    return Math.round(a['price']) - Math.round(b['price']);
                }
            };

            return Store;
        }());

        return Store;
    })
}());