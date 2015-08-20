function initializeScript2() {
    'use strict';
    var input = document.getElementById('numbers').value,
        numbers = input.replace(/\s+/g, '').split(',');
    
    var index=findMax(numbers);
    if (index) {
        jsConsole.writeLine('element at position  ' + index + '  is bigger than its neighbours');
    } else{
        jsConsole.writeLine('there is no such element');
    }
}

function findMax(numbers) {
    var pos;

    for (pos = 1; pos * 1 < numbers.length - 1; pos++) {
        if (isMax(numbers, pos)) {
            return pos;
        }
    }
    return -1;
}