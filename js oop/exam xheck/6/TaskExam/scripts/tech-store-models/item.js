define(function () {
    var Item = (function () {
        function Item(type, name, price) {
            this._type = type;
            this._name = name;
            this._price = price;
        };


        return Item;
    }());

    return Item;
});