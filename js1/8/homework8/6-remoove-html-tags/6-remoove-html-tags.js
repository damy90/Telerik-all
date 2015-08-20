function initializeScript() {
    "use strict";
    var text = document.getElementById('text').value;

    jsConsole.writeLine(remooveHtmlTags(text));
}

function remooveHtmlTags(text) {
    var regex = /(<([^>]+)>)/ig;
    var result = text.replace(regex, "");
    jsConsole.writeLine(result);
}