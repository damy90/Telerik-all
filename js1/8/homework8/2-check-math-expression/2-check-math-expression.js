function initializeScript() {
    "use strict";
    var expression = document.getElementById('expression').value;

    jsConsole.writeLine(checkBrackets(expression));
}

function checkBrackets(expression) {
    var count = 0,
        i,
        elements = expression.split(''),
        misplacedClosingBracket = false;

    for (i in elements) {
        if (elements[i] === ')') {
            count--;
        } else if (elements[i] === '(') {
            count++;
        }
        if (count < 0) {
            //closing a bracket that was not open
            misplacedClosingBracket = true;
            break;
        }
    }
    return (count === 0 || (!misplacedClosingBracket));
}