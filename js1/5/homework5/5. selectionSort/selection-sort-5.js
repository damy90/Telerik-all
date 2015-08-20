/*jslint browser: true */
function selectionSort() {
    var input = document.getElementById('numbers').value,
        elements = input.replace(/\s+/g, '').split(','),
        indexFirstUnsorted,
        indexMin,
        i,
        memory;
    //clean invalid input
    for (i in elements) {
        if ((isNaN(elements[i] * 1) || (elements[i] === ''))) {
            elements.splice(i, 1);
        }
    }

    for (indexFirstUnsorted = 0; indexFirstUnsorted < elements.length - 1; indexFirstUnsorted++) {
        indexMin = indexFirstUnsorted;
        //find index of the smallest unsorted element
        for (i = indexFirstUnsorted + 1; i < elements.length; i++) {
            if (elements[indexMin] * 1 > elements[i] * 1) {
                indexMin = i;
            }
        }
        //switch the smallest unsorted element with the first unsorted element
        if (indexMin !== indexFirstUnsorted) {
            memory = elements[indexFirstUnsorted];
            elements[indexFirstUnsorted] = elements[indexMin];
            elements[indexMin] = memory;
        }
    }

    jsConsole.writeLine(elements);
}