define([], function () {
    var Item = (function () {
        function Item(type, name, price) {
            if ((type !== 'accessory') && (type !== 'smart-phone') && (type !== 'notebook') && (type !== 'pc') && (type !== 'tablet')) {
                throw {
                    message: 'Invalid type! Possible values are:  "accessory", "smart-phone", "notebook", "pc" and "tablet".'
                };
            }
            if (((typeof name !== 'String') && (typeof name !== 'string')) || (name.length < 6) || (name.length > 40)) {
                throw {
                    message: 'Invalid name! It has to be a string of 6-40 characters.'
                }
            }
            if ((typeof price !== 'number') && (typeof price !== 'Number')) {
                throw {
                    message: 'Invalid price! It has to be a number.'
                }
            }
            this._type = type;
            this._name = name;
            this._price = price;
        }
        
        return Item;
    }());

    return Item;
});