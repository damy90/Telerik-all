function initializeScript() {
    var number = jsConsole.readFloat('#number');
    reverse(number);
}

function reverse(number) {
    'use strict';
    var didgitsReverse = number.toString().split('').reverse(),
        index;

    for (index in didgitsReverse) {
        jsConsole.write(didgitsReverse[index]);
    }
    jsConsole.writeLine('');
}