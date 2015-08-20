function initializeScript() {
    "use strict";
    var text = document.getElementById('text').value,
        searchString = document.getElementById('searchString').value;

    jsConsole.writeLine(findInText(text, searchString));
}

function findInText(string, substring) {
    string = string.toLowerCase();
    return (string.split(substring).length - 1);
}