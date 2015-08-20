function divisableBy35() {
    "use strict";
    var number = jsConsole.readInteger("#number");

    jsConsole.writeLine(number % 5 === 0 && number % 7 === 0);//%35
}