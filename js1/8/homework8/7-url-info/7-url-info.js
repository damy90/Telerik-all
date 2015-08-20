function initializeScript() {
    "use strict";
    var url = document.getElementById('url').value;

    jsConsole.writeLine(JSON.stringify(parseUrl(url)));
}

function parseUrl(url) {
    url = url.split('://');
    var protocol = url[0],
        server = url[1].substring(0, url[1].indexOf('/')),
        resource = url[1].substring(url[1].indexOf('/'), url[1].length),
        parsedUrl = {
            protocol: protocol,
            server: server,
            resource: resource
        };
    return parsedUrl;
}