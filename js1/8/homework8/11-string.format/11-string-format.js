function stringFormat() {
    var output = arguments[0];

    for (var i = 1; i < arguments.length; i++) {
        output = output.replace(new RegExp('\\{' + (i - 1) + '\\}', 'g'), arguments[i]);
    }

    return output;
}

var str = stringFormat('{0}, {1}, {0} text {2}', 1, 'Pesho', 'Gosho');

jsConsole.writeLine(str);