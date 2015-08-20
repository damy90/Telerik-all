function initializeScript() {
    var input = document.getElementById('numbers').value,
        searchNumber = jsConsole.readInteger('#findNumber'),
        numbers = input.replace(/\s+/g, '').split(',');
    countOccurances(numbers, searchNumber);
}

function countOccurances(numbers, searchNumber) {
    'use strict';
    var count = 0,
        index;
    //clean invalid input
    for (index in numbers) {
        if ((isNaN(numbers[index] * 1) || (numbers[index] === ''))) {
            numbers.splice(index, 1);
        }
    }

    for (index in numbers) {
        if (numbers[index] * 1 === searchNumber * 1) {
            count += 1;
        }
    }

    jsConsole.writeLine(count);
}