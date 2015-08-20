function numberToWords() {
    'use strict';
    var number = jsConsole.readInteger('#number'),
        words = '',
        unitsMap = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine', 'ten', 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'],
        tensMap = ['zero', 'ten', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'];

    console.log(words);
    if (number >= 0 && number <= 999) {
        if (Math.floor(number/100) > 0) {
            words += unitsMap[Math.floor(number/100)];
            words += ' hundred ';
            number %= 100;
        }

        if (number > 0) {
            if (words !== '') {
                words += 'and ';
            }

            if (number < 20) {
                words += unitsMap[number];
            } else {
                words += tensMap[Math.floor(number/10)];
                if ((number % 10) > 0) {
                    words += '-' + unitsMap[number % 10];
                }
            }
        } else if (words === '') {
            words = 'zero';
        }

        jsConsole.writeLine('The number in words: ' + words);
    } else {
        jsConsole.writeLine('Please enter a number between 0 and 999');
    }
}