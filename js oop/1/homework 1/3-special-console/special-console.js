var specialConsole = (function () {
    function placeHolder(input) {
        var format = input[0];
        for (var i = 0; i < 30; i++) {
            while (format.indexOf('{' + i + '}') != -1) {
                format = format.replace('{' + i + '}', input[i + 1]);
            }
        }
        return format;
    }

    function writeLine(message) {
        var argsLenght = arguments.length;
        if (argsLenght == 1) {
            console.log(message.toString());
        } else {

            var string = placeHolder(arguments);
            console.log(string.toString());
        }
    }

    function writeWarning(message) {
        var argsLenght = arguments.length;
        if (argsLenght == 1) {
            console.warn(message.toString());
        } else {

            var string = placeHolder(arguments);
            console.warn(string.toString());
        }
    }

    function writeError(message) {
        var argsLenght = arguments.length;
        if (argsLenght == 1) {
            console.error(message.toString());
        } else {
            var string = placeHolder(arguments);
            console.error(string.toString());
        }
    }
    return {
        writeLine: writeLine,
        writeWarning: writeWarning,
        writeError: writeError
    };
}());

specialConsole.writeLine("Message: hello");
//logs to the console "Message: hello" 
specialConsole.writeLine("Message: {0}", "hello");
//logs to the console "Message: hello" 
specialConsole.writeError("Error: {0}", "Something happened");
specialConsole.writeWarning("Warning: {0}", "A warning");