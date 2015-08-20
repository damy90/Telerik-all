function compare() {
    var arr1 = document.getElementById('string1').value.split(''),
        arr2 = document.getElementById('string2').value.split(''),
        minLength = Math.min(arr1.length, arr2.length),
        index;

    for (index = 0; index < minLength; index += 1) {
        if (arr1[index] < arr2[index]) {
            jsConsole.writeLine('The element ' + index + ' in the 1-st array is smaller');
        } else if (arr1[index] < arr2[index]) {
            jsConsole.writeLine('The element ' + index + ' in the 1-st array is bigger');
        } else {
            jsConsole.writeLine('The elements at position ' + index + ' are equal');
        }
    }
    if (arr1.length < arr2.length) {
        jsConsole.writeLine('Array 1 is shorter');
    } else if (arr1.length > arr2.length) {
        jsConsole.writeLine('Array 1 is longer');
    }
}