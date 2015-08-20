function solveEquation() {
    'use strict';
    var a = jsConsole.readFloat('#a'),
        b = jsConsole.readFloat('#b'),
        c = jsConsole.readFloat('#c'),
        discriminant,
        result1,
        result2;

    if (a !== 0) {
        discriminant = b * b - 4 * a * c;
        if (discriminant > 0) {
            result1 = (-b - Math.sqrt(discriminant)) / (2 * a);
            result2 = (-b + Math.sqrt(discriminant)) / (2 * a);
            jsConsole.writeLine('x1= ' + result1 + ' x2= ' + result2);
        }

        else if (discriminant === 0)
            jsConsole.writeLine('x= ' + (-b / 2 * a));
        else
            jsConsole.writeLine('There are no real rooths');
    } else if (a === 0 && b === 0 && c === 0)
        jsConsole.writeLine('x= Every real number');
    else if (a === 0 && b !== 0)
        jsConsole.writeLine('x= ' + (-c / b));
    else
        jsConsole.writeLine('There are no real rooths');
}