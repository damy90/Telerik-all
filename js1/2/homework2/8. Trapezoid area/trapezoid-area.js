function calcArea() {
    "use strict";
    var a = jsConsole.readFloat("#a"),
        b = jsConsole.readFloat("#b"),
        h = jsConsole.readFloat("#h"),
        area = (a+b)*h/2;

    jsConsole.writeLine("The area is: " + area);
}