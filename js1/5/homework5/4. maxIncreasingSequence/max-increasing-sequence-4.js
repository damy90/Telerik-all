/*jslint browser: true */
function findMaxSequence() {
    var input = document.getElementById('numbers').value,
        numbers = input.replace(/\s+/g, '').split(','),
        countMax = 1,
        count,
        firstElementIndex = 0,
        i,
        noValidInput = true;

    for (i = 0, count = 1; i < numbers.length; i++) {
        if (!(isNaN(numbers[i] * 1) || (numbers[i] === ''))) {
            if (numbers[i] * 1 === (numbers[i + 1] - 1))
                count++;
            else
                count = 1;
            if (count > countMax) {
                countMax = count;
                firstElementIndex = i + 2 - count;
            }
            noValidInput = false;
        }
    }

    if (!noValidInput) {
        for (i = 0; i < countMax; i++)
            jsConsole.write(numbers[firstElementIndex + i] * 1 + ', ');
        jsConsole.writeLine('');
    } else {
        jsConsole.writeLine('There was no valid input');
    }
}