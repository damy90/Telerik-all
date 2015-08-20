function testDeepCoppy() {
    var person = {
        name: 'go6ko',
        lastName: 'go6kov',
        age: 200,
        hair: {
            color: 'black',
            type: 'lawn mower accident'
        }
    };
    jsConsole.writeLine('Person: ' + JSON.stringify(person));
    jsConsole.writeLine('');
    jsConsole.writeLine('Copying person');
    var evilTwin = deepCopy(person);
    jsConsole.writeLine('evil twin: ' + JSON.stringify(evilTwin));

    jsConsole.writeLine('');
    jsConsole.writeLine('Changing evil twin');
    evilTwin.age = 300;
    evilTwin.hair.type = 'Elvis';
    jsConsole.writeLine('evil twin: ' + JSON.stringify(evilTwin));

    jsConsole.writeLine('');
    jsConsole.writeLine('test primitive types');
    var text = 'Goodbye and thanks for all the fish';
    var copyText = deepCopy(text);
    jsConsole.writeLine('Original text: ' + text);
    jsConsole.writeLine('Copied text: ' + text);
}

function deepCopy(anyObject) {
    return JSON.parse(JSON.stringify(anyObject));
}