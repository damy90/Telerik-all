function calcArea() {
    "use strict";
    var height = jsConsole.readFloat("#height"),
        width = jsConsole.readFloat("#width");

    jsConsole.writeLine("Area = " + height * width);
}