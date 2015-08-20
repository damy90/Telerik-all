function bit3() {
    "use strict";
    /*jslint bitwise: true */
    var number = jsConsole.readInteger("#number"),
        position = 3,
        mask = 1 << position,
        bit = (number & mask) >> position;

    jsConsole.writeLine('The 3-th bit is: ' + bit);
}