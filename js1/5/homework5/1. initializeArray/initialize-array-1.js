function init() {
    var arr = [],
        index;

    for (index = 0; index < 20; index += 1) {
        arr[index] = 5 * index;
        jsConsole.writeLine(arr[index]);
    }
}