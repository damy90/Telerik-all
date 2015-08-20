function sortNumbers() {
    "use strict";
    var number1 = jsConsole.readInteger("#number1"),
        number2 = jsConsole.readInteger("#number2"),
        number3 = jsConsole.readInteger("#number3"),
        memory;

    if (number1 > number2) {
        memory = number1;
        number1 = number2;
        number2 = memory;
    }
    if (number1 > number3) {
        memory = number1;
        number1 = number3;
        number3 = memory;
    }
    if (number2 > number3) {
        memory = number2;
        number2 = number3;
        number3 = memory;
    }
    jsConsole.writeLine("Numbers in assending order: " + number1 + ', ' + number2 + ', ' + number3);
}