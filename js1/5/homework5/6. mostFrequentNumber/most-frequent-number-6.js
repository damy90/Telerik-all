/*jslint browser: true */
function mostFrequent() {
    var input = document.getElementById('numbers').value,
        numbers = input.replace(/\s+/g, '').split(','),
        countMax = 0,
        count,
        numberMostFrequent,
        i,
        numberIndex;
    //clean invalid input
    for (i in numbers) {
        if ((isNaN(numbers[i] * 1) || (numbers[i] === ''))) {
            numbers.splice(i, 1);
        }
    }

    for (numberIndex in numbers) {
        count = 0;
        for (i = numberIndex; i < numbers.length; i++) {
            if (numbers[numberIndex] == numbers[i]) {
                count++;
            }
        }
        if (countMax < count) {
            countMax = count;
            numberMostFrequent = numbers[numberIndex];
        }
    }

    jsConsole.writeLine(numberMostFrequent + ' (' + countMax + ' times)');
}