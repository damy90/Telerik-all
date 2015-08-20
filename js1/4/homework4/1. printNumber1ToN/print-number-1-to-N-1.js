function printNumbers1ToN() {
    var number = jsConsole.readInteger("#number"),
        currentNum;

    if (number >= 1) {
        for (currentNum = 1; currentNum <= number; currentNum++) {
            jsConsole.writeLine(currentNum);
        }

    } else if (number < 1) {
        for (currentNum = 1; currentNum >= number; currentNum--) {
            jsConsole.writeLine(currentNum);
        }
    }
}