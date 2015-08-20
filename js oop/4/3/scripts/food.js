/// <reference path="_reference.js" />

/*
 * Food object
 */
var Food = Food || {};
Food = (function () {

    function Apple(x, y, size) {
        GameObject.Part.call(this, x, y, size);
    }

    Apple.prototype = new GameObject.Part();
    Apple.prototype.constructor = Apple;

    return {
        Apple: Apple,
    }
})();