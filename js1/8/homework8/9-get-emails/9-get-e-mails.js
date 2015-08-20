function initializeScript() {
    "use strict";
    var text = document.getElementById('text').value;

    jsConsole.writeLine(getEmails(text));
}

function getEmails(text) {
    var emails = text.match(/\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*/g);
    return emails;
}