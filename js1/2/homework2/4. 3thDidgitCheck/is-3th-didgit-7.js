function isDidgit7() {
    "use strict";
    var number = jsConsole.readInteger("#number"),
        didgit3 = (Math.floor(number/100)) % 10;

    jsConsole.writeLine(didgit3 === 7);
}