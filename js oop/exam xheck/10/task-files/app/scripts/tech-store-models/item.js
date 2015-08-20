/// <reference path="../libs/require.js" />

define([], function () {
    'use strict';
    var Item;
    Item = (function () {
        function Item(type, name, price) {
            this._type = type;
            this._name = name;
            this._price = price;
        }
        //TODO to make checks for the input /Name is a regular string between 6 and 40-characters-long
        return Item;
    })();
    return Item;
});