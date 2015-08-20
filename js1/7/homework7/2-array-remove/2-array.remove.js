function initializeScript() {
    "use strict";
    var input = document.getElementById('values').value,
        numbers = input.split(' ').join('').split(',');
    numbers = numbers.remove(1);
    jsConsole.writeLine(numbers);
}

Array.prototype.remove = function (value) {
    if (this == null) {
        throw new TypeError();
    }

    var result = [];

    var size = this.length;
    for (var i = 0; i < size; i++) { //for (var i in this) шо не стаа така и аз не знам 
        if (this[i] != value) {
            result.push(this[i]);
        }
    }

    return result;
};