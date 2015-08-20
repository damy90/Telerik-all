/*jslint browser: true */
function binarySearch() {
    var input = document.getElementById('numbers').value,
        searchedNumber = jsConsole.readInteger('#findNumber'),
        numbers = input.replace(/\s+/g, '').split(','),
        startSearch = 0,
        endSearch = numbers.length - 1,
        middleIndex,
        found = false,
        i;
    //clean invalid input
    for (i in numbers) {
        if ((isNaN(numbers[i] * 1) || (numbers[i] === ''))) {
            numbers.splice(i, 1);
        }
    }

    while (startSearch * 1 <= endSearch * 1) {
        middleIndex = (startSearch + endSearch)>>1;//Math.floor((startSearch + endSearch) / 2);

        if (numbers[middleIndex] * 1 === searchedNumber * 1) {
            found = true;
            break;
        }

        if (numbers[middleIndex] * 1 < searchedNumber * 1) {
            startSearch = middleIndex + 1;
        } else if (numbers[middleIndex] * 1 > searchedNumber * 1) {
            endSearch = middleIndex - 1;
        }
    }
    if (found) {
        jsConsole.writeLine('Index is: ' + middleIndex);
    } else {
        jsConsole.writeLine('Not found');
    }
}