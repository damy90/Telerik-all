function isPrime() {
    "use strict";
    /*jslint bitwise: true */
    var number = jsConsole.readInteger("#number");

    if ((number >= 1) && (number <= 100)) {
        if ((number === 2 || number === 3 || number === 5 || number === 7) || !(number % 2 === 0 || number % 3 === 0 || number % 5 === 0 || number % 7 === 0) && number !== 1) {
            jsConsole.writeLine("The number is prime");
        }
        else {
            jsConsole.writeLine("The number is not prime");
        }
    }
    else {
        jsConsole.writeLine("Number is out of range");
    }
}