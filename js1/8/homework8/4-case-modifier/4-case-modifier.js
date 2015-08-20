var modeNormal = 0,
    modeUpCase = 1,
    modeLowCase = 2,
    modeRandomCase = 3;

function initializeScript() {
    "use strict";
    var text = document.getElementById('text').value;

    readTags(text);
}

function readTags(inputText) {
    var modes = [];

    if (inputText.charAt(0) !== '<') {
        inputText = 'normalcase>' + inputText;
    }
    var arr = inputText.split('<');

    var currentMode;
    for (var i in arr) {
        if (arr[i].charAt(0) == '/' && i !== 0) {
            modes.pop();
            currentMode = modes[modes.length - 1];
        } else {
            if (arr[i].indexOf('normalcase>') === 0) {
                currentMode = modeNormal;
            } else if (arr[i].indexOf('upcase>') === 0) {
                currentMode = modeUpCase;
            } else if (arr[i].indexOf('lowcase>') === 0) {
                currentMode = modeLowCase;
            } else if (arr[i].indexOf('mixcase>') === 0) {
                currentMode = modeRandomCase;
            }
            modes.push(currentMode);
        }
        var text = arr[i].substr(arr[i].indexOf('>') + 1, arr[i].length - 1); //take the text after the opening tag
        printText(text, currentMode);
    }
}

function printText(text, mode) {
    switch (mode) {
    case modeRandomCase:
        text = toRandomCase(text);
        break;
    case modeUpCase:
        text = text.toUpperCase();
        break;
    case modeLowCase:
        text = text.toLowerCase();
        break;
    }
    jsConsole.write(text);
}

function toRandomCase(text) {
    text = text.toLowerCase();
    var result = '';
    for (var i = 0; i < text.length; i++) {
        result = result + ((Math.random() > 0.5) ? text.charAt(i).toUpperCase() : text.charAt(i));
    }
    return result;
}