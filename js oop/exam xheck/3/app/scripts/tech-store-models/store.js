define(['tech-store-models/item'], function (Item) {
    var Store = (function () {

        function sortLexicographically (items) {
            var sortedItems = items.sort(sortByName);
            return sortedItems;
        }

        function sortAscending (items) {
            var sortedItems = items.sort(sortByPrice);
            return sortedItems;
        }  

        function sortByName(item1, item2) {
            return item1._name - item2._name;
        }

        function sortByPrice(item1, item2) {
            return item1._price - item2._price;
        }

        function Store(name) {
            if (((typeof name !== 'String') && (typeof name !== 'string')) || (name.length < 6) || (name.length > 30)) {
                throw {
                    message: 'Invalid name! It has to be a string of 6-30 characters.'
                }
            }
            this._name = name;
            this._items = [];
        }

        Store.prototype = {
            addItem: function (item) {
                if (!(item instanceof Item)) {
                    throw {
                        message: 'Trying to add an object that is not an instance of Item!'
                    };
                }
                this._items.push(item);
                return this;
            },
            getAll: function () {
                var lexSortItems = sortLexicographically (this._items);
                this._items = lexSortItems;
                return this._items;
            },

            getSmartPhones: function () {
                var i, len, item;
                this._smartPhones = [];
                for (i = 0, len = this._items.length; i < len; i += 1) {
                    item = this._items[i];
                    if (item._type === 'smart-phone') {
                        this._smartPhones.push(item);
                    }
                }
                sortLexicographically(this._smartPhones);
                return this._smartPhones;
            },

            getMobiles: function () {
                var i, len, item;
                this._mobiles = [];
                for (i = 0, len = this._items.length; i < len; i += 1) {
                    item = this._items[i];
                    if ((item._type === 'smart-phone') || (item._type === 'tablet')) {
                        this._mobiles.push(item);
                    }
                }
                sortLexicographically(this._mobiles);
                return this._mobiles;
            },

            getComputers: function () {
                var i, len, item;
                this._computers = [];
                for (i = 0, len = this._items.length; i < len; i += 1) {
                    item = this._items[i];
                    if ((item._type === 'pc') || (item._type === 'notebook')) {
                        this._computers.push(item);
                    }
                }
                sortLexicographically(this._computers);
                return this._computers;
            },

            filterItemsByType: function (filterType) {
                var i, len, item;
                this._filteredByType = [];
                for (i = 0, len = this._items.length; i < len; i += 1) {
                    item = this._items[i];
                    if (item._type === filterType) {
                        this._filteredByType.push(item);
                    }
                }
                sortLexicographically(this._filteredByType);
                return {
                    type: filterType,
                    items: this._filteredByType
                };
            },
            filterItemsByPrice : function (options) {
                var min, max;
              //  if (!options.min) {
                    min = 0;
            //    }
           //     else {
            //        min = options.min;
            //    }

           //     if (!options.max) {
                    max = Number.MAX_VALUE;
           //     }
           //     else {
           //         max = options.max;
           //     }


                var i, len, item;
                this._filteredByPrice = [];
                for (i = 0, len = this._items.length; i < len; i += 1) {
                    item = this._items[i];
                    if ((item._price >= min) && (item._price <= max)) {
                        this._filteredByPrice.push(item);
                    }
                }
                sortAscending(this._filteredByPrice);
                return {
                    min: min,
                    max: max,
                    items: this.filterItemsByPrice
                }
            },

            countItemsByType: function () {
                this._countedByType = [];
                var types = ['accessory', 'smart-phone', 'notebook', 'pc', 'tablet'],
                    i, j, count, 
                    lenTypes = types.length,
                    lenItems = this._items.length;
                for (i = 0; i < lenTypes; i += 1) {
                    count = 0;
                    for (j = 0; j < lenItems; j += 1) {
                        if (this._items[j]._type === types[i]) {
                            count += 1;
                        }                      
                    }
                    this._countedByType.push({ key: types[i], value: count });
                }
                return this._countedByType;
            },

            filterItemsByName: function(partOfName) {
                console.log('Ask me later.');
                return this;
            }
            
        }
        return Store;
    }());
    return Store;
});