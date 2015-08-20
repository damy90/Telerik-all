/// <reference path="_reference.js" />

var Texts = Texts || {};
Texts = (function () {
    function Text(x, y, label, number) {
        this.x = x;
        this.y = y;
        this.label = label;
        this.number = number;
    }

    Text.prototype.getPosition = function () {
        return {
            x: this.x,
            y: this.y
        }
    }

    return {
        Text: Text
    }
})();