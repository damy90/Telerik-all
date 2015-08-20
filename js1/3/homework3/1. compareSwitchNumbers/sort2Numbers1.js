function sort2Numbers() {
    "use strict";
    var number1 = jsConsole.readFloat("#number1"),
        number2 = jsConsole.readFloat("#number2"),
        memory;

    if (number1 > number2) {
        memory = number1;
        number1 = number2;
        number2 = memory;
    }
    
    jsConsole.writeLine(number1 + ' ' + number2);
}