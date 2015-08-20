function findBigest() {
    "use strict";
    var number1 = jsConsole.readInteger("#number1"),
        number2 = jsConsole.readInteger("#number2"),
        bigest = number1;

    if (number1 === number2 && number1 === number3)
        jsConsole.writeLine("All numbers are equal");
    else if (number1 < number2) {
        if (number2 < number3)
            bigest = number3;
        else
            bigest = number2;
    } else {
        if (number1 < number3)
            bigest = number3;
        else
            bigest = number1;
    }

    jsConsole.writeLine("The bigest number is: " + bigest);
}