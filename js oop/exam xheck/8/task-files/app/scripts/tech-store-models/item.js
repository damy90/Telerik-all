(function () {
    var types = {
        'accessory': true,
        'smart-phone': true,
        'notebook': true,
        'pc': true,
        'tablet': true
    };

    define([], function () {
        var Item;
        Item = (function () {
            function Item(type, name, price) {
                this.type = this.setType(type);
                this.name = this.setName(name);
                this.price = this.setPrice(price);
            }

            Item.prototype = {
                setType: function (type) {
                    if (!types[type]) {
                        throw new Error("Invalid item type.");
                    } else return type;
                },

                setName: function (name) {
                    if (name && name.hasOwnProperty('length') && name.length >= 6 && name.length <= 40) {
                        return name;
                    } else {
                        throw new Error("Name must be between 6 and 40 characters long.");
                    }
                },

                setPrice: function (price) {
                    if (price === Math.floor(price)) {
                        throw new Error("Price number is not a decimal floating point number.");
                    } else return price;
                }
            };

            return Item;
        }());

        return Item;
    })
}());