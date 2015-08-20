function initializeScript() {
    "use strict";
    var text = document.getElementById('text').value;

    jsConsole.writeLine(findPalindromes(text));
}

function findPalindromes(text) {
    var palindromes = [],
        words = text.split(' '),
        i;
    for (i in words) {
        if (words[i].split('').join('') === words[i].split('').reverse().join('') && words[i].length > 1) {
            palindromes.push(words[i]);
        }
    }
    return palindromes;
}