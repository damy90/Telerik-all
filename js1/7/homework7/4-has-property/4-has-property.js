function initializeScript() {
    "use strict";
    var input = document.getElementById('JSON').value,
        object = JSON.parse(input),
        property = document.getElementById('property').value;
    var hasProp = hasProperty(object, property);
    jsConsole.writeLine(hasProp);
}


function hasProperty(object, property) {
    if (property in object) {
        return true;
    }
    return false;
}