define(['todo-list/item'], function (Item) {
    'use strict';
    var Section;
    Section = (function () {
        function Section(title) {
            this._title = title;
            this._items = [];
        }

        Section.prototype = {
            add: function (item) {
                if (!(item instanceof(Item))) {
                    throw Error('not an item');
                }
                this._items.push(item);
                return this;
            },
            getData: function () {
                return {
                    title: this._title,
                    items: this._items
                };
            }
        };

        return Section;
    }());
    return Section;
});