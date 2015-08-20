/// <reference path="_reference.js" />

/*
 * GameObject for game objects positioning
 */

var GameObject = GameObject || {};
GameObject = (function () {

    function Part(x, y, size) {
        this.x = x;
        this.y = y;
        this.size = size;
    }

    Part.prototype.getPosition = function () {
        return {
            x: this.x,
            y: this.y
        };
    }

    Part.prototype.setPosition = function (x, y) {
        this.x = x;
        this.y = y;
    }

    Part.prototype.getSize = function () {
        return this.size;
    }

    return {
        Part: Part
    };
})();