define(function(){
    var Items = (function(){
        var Items = function(type, name, price){
            this.type = type;
            this.name = name;
            this.price = price;
        };
        return Items;
    }());
    return Items;
});