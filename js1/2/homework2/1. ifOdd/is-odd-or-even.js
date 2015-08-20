function isEven() {
    "use strict";
    var number = jsConsole.readInteger("#number");

    if (number % 2 === 0) {
        jsConsole.writeLine("number: " + number + " is even");
    } else {
        jsConsole.writeLine("number: " + number + " is odd");
    }
}
