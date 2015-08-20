define(function () {
    'use strict';
    var Item;
    Item = (function () {
        function Item(type, name, price) {
            if(validateInput(arguments)){
                this._type= type;
                this._name = name;
                this.price = price;
            }
        }

        function validateInput(args){
            var isValid = true;

            switch (args[0]){
                case 'accessory':break;
                case 'smart-phone':break;
                case 'notebook':break;
                case 'pc':break;
                case 'tablet':break;
                default: throw{message: 'Invalid item type!'}
            }

            if(args[1].length < 6 || args[1].length > 40){
                throw {message: 'Invalid item name!'}
            }

            if(!args[2] instanceof Number || args[2] < 0){
                throw {message: 'Price must be a positive number!'}
            }

            return isValid;
        }

        return Item;
    })();
    return Item;
});