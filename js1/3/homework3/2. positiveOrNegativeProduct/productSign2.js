function productSign() {
    "use strict";
    var number1 = jsConsole.readInteger("#number1"),
        number2 = jsConsole.readInteger("#number2"),
        number3 = jsConsole.readInteger("#number3");

    if (number1 === 0 || number2 === 0 || number3 === 0)
        jsConsole.writeLine("The product is zero");
    else if (((number1 > 0) === (number2 > 0)) === (number3 > 0)) //example: (false==false) is true and is == true
        jsConsole.writeLine("The product is positive (+)");
    else
        jsConsole.writeLine("The product is negative (-)");
}