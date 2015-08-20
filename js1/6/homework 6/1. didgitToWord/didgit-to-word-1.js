function initializeScript() {
    var didgit = jsConsole.readInteger('#number') % 10;
    getDidgitName(didgit);
}

function getDidgitName(didgit) {
    'use strict';
    var didgitsMap = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"],
        word;

    if (isNaN(didgit)) {
        jsConsole.writeLine('Not a number');
        return;
    }

    word = didgitsMap[didgit];
    jsConsole.writeLine(word);
}