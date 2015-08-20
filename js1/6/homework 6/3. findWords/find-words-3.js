function initializeScript() {
    var text = document.getElementById('text').value,
        word = document.getElementById('findWord').value,
        isCaseSensitive = document.getElementById('isCaseSensitive').checked;
    jsConsole.writeLine(findWords(text, word, isCaseSensitive));
}

function findWords(text, word, isCaseSensitive) {
    var regex = new RegExp('\\b' + word + '\\b', 'g');
    if (isCaseSensitive === true) {
        regex = new RegExp('\\b' + word + '\\b', 'gi');
    }
    return text.match(regex).length;
}