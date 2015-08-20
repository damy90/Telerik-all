function initializeScript() {
    var input = document.getElementById('numbers').value,
        pos = jsConsole.readInteger('#pos'),
        numbers = input.replace(/\s+/g, '').split(',');
    
    if (pos < 1 || pos >= numbers.length) {
        jsConsole.writeLine('The number does not have two neighbours or doesn\'t exist');
    } else {
        jsConsole.writeLine('The number is greater than its neighbours: ' + isMax(numbers, pos));
    }
}

function isMax(numbers, pos) {
    return (numbers[pos] * 1 > numbers[pos - 1] * 1 && numbers[pos] * 1 > numbers[pos + 1] * 1);
}