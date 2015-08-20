function initializeScript() {
    "use strict";
    var html = document.getElementById('html').value;

    jsConsole.writeLine(ahrefToUrl(html));
}

function ahrefToUrl(html) {
    var linkIndex = html.indexOf('<a href="');
    while (linkIndex !== -1) {
        html = html.replace('<a href="', '[URL=');
        html = html.replace('">', ']');
        html = html.replace('</a>', '[/URL]');

        linkIndex = html.indexOf('<a href="');
    }

    return html;
}