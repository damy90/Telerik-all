function findBigest() {
    "use strict";
    var number = [],
        bigest,
        valNumber;

    number[0] = jsConsole.readFloat('#number1');
    number[1] = jsConsole.readFloat('#number2');
    number[2] = jsConsole.readFloat('#number3');
    number[3] = jsConsole.readFloat('#number4');
    number[4] = jsConsole.readFloat('#number5');

    bigest = number[0];
    for (valNumber = 1; valNumber < 5; valNumber++) {
        if (number[valNumber] > bigest) {
            bigest = number[valNumber];
        }
    }

    jsConsole.writeLine("The bigest number is: " + bigest);
}