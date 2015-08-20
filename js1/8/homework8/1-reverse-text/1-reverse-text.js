function initializeScript() {
    "use strict";
    var string = document.getElementById('string').value;

    jsConsole.writeLine(reverseText(string));
}

function reverseText(string) {
    return string.split('').reverse().join('');
}