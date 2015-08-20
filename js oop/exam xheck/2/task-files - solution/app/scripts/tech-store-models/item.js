define([], function () {
    var Item;
    Item = (function () {
        var validTypes = [ 'accessory', 'smart-phone', 'notebook', 'pc', 'tablet'],
            nameMinLen = 6,
            nameMaxLen = 40;

        function Item(type, name, price) {
            if (validTypes.indexOf(type) == -1) {
                throw {
                    message: 'Invalid item type!'
                }
            }
            if (!(typeof (name) == 'string')) {
                throw {
                    message: 'Item name must be string'
                }
            }
            var nameLength = name.length;
            if (nameLength < nameMinLen || nameLength > nameMaxLen) {
                throw {
                    message: 'Invalid item name length!'
                }
            }
            if (!(typeof(price) == 'number')) {
                throw {
                    message: 'Price should be a number!'
                }
            }

            this.type = type;
            this.name = name;
            this.price = price;
        }

        return Item;
    })();

    return Item;
})