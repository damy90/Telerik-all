/// <reference path="../libs/require.js" />
// I have commented some of the app.js functions !!!!!
define([], function () {
    'use strict';
    var Store;
    Store = (function () {
        function Store(name) {
            this._name = name;
            this._items = [];
        }

        Store.prototype = {
            addItem: function (item) {
                this._items.push(item);
                return this;
            },
            getAll: function () {

                return sortItems(this._items, '_name');
            },
            getSmartPhones: function () {
                var selectedItems = [];

                selectedItems = getItemsByType(this._items, 'smart-phone');
                return sortItems(selectedItems, '_name');
            },
            getMobiles: function () {
                var selectedItems = [];

                selectedItems = getItemsByMulipleTypes(this._items, 'smart-phone', 'tablet');
                return sortItems(selectedItems, '_name');
            },
            getComputers: function () {
                var selectedItems = [];

                selectedItems = getItemsByMulipleTypes(this._items, 'pc', 'notebook');
                return sortItems(selectedItems, '_name');
            },
            filterItemsByType: function (filterType) {
                var selectedItems = [];

                selectedItems = getItemsByType(this._items, filterType);
                return sortItems(selectedItems, '_name');
            },
            filterItemsByPrice: function (options) {
                var minValue,
                    maxValue,
                    selectedItems = [];

                minValue = options.min || 0;
                maxValue = options.max || 99999999999999999;

                selectedItems = getItemsByPrice(this._items, minValue, maxValue);
                return sortItemsByPrice(selectedItems);
            }
        };

        function sortItems(items, sortBy) {
            items.sort(function (first, second) {
                return first[sortBy].localeCompare(second[sortBy]);
            });
            return items.slice(0);
        }

        function getItemsByType(items, type) {
            var i,
                len,
                selectedItems = [];

            len = items.length;

            for (i = 0; i < len; i += 1) {
                if (items[i]._type === type) {
                    selectedItems.push(items[i]);
                }
            }

            return selectedItems.slice(0);
        }

        function getItemsByMulipleTypes(items, type1, type2) {
            var selectedItems = [],
                slectedItemsType1 = [],
                slectedItemsType2 = [];
            slectedItemsType1 = getItemsByType(items, type1);
            slectedItemsType2 = getItemsByType(items, type2);
            selectedItems = slectedItemsType1.concat(slectedItemsType2);

            return selectedItems.slice(0);
        }

        function getItemsByPrice(items, minValue, maxValue) {
            var i,
                len,
                selectedItems = [];

            len = items.length;

            for (i = 0; i < len; i += 1) {
                if ((maxValue >= items[i]._price) && (items[i]._price >= minValue)) {
                    selectedItems.push(items[i]);
                }
            }

            return selectedItems.slice(0);
        }

        function sortItemsByPrice(items) {
            items.sort(function (first, second) {
                return first._price - second._price;
            });
            return items.slice(0);
        }

        return Store;
    })();
    return Store;
});