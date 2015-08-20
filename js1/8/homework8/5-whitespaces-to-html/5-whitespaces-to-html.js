function initializeScript() {
    "use strict";
    var text = document.getElementById('text').value;

    jsConsole.writeLine(whitespaces2Html(text));
}

function whitespaces2Html(text) {
    var regexp = /\s/g;
    text = text.replace(regexp, '&amp;nbsp;');
    return text;
}