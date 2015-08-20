/*jslint browser: true */
function findMaxSequence() {
    var input = document.getElementById('numbers').value,
        numbers = input.replace(/\s+/g, '').split(','),
        countMax = 1,
        count,
        sequence,
        i,
        noValidInput = true;

    for (i = 0, count = 1; i < numbers.length; i++) {
        if (!(isNaN(numbers[i] * 1) || (numbers[i] === ''))) {
            if (numbers[i] === numbers[i + 1])
                count++;
            else
                count = 1;
            if (count > countMax) {
                countMax = count;
                sequence = numbers[i];
            }
            noValidInput = false;
        }
    }
    console.log(countMax);
    if (!noValidInput) {
        jsConsole.writeLine('The longest sequence is: ' + Array(countMax + 1).join(sequence));
    } else {
        jsConsole.writeLine('There was no valid input');
    }
}