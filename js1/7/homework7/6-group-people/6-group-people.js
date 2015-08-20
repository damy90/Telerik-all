function testGroup(groupCriteria) {
    var people = [
            {
                firstName: 'Gosho',
                lastName: 'Petrov',
                age: 32
            },
            {
                firstName: 'Gosho',
                lastName: 'Todorov',
                age: 28
            },
            {
                firstName: 'Bay',
                lastName: 'Petrov',
                age: 71
            },
            {
                firstName: 'Gosho',
                lastName: 'Todorov',
                age: 28
            },
        ],
        groups = (group(people, groupCriteria));
    for (var i in groups) {
        jsConsole.writeLine('Group: ' + groupCriteria + ' ' + i);
        jsConsole.writeLine(JSON.stringify(groups[i]));
    }
    jsConsole.writeLine('');

}

function group(people, property) {
    var result = {};
    for (var i = 0; i < people.length; i++) {
        var p = people[i][property];
        if (typeof result[p] === "undefined") {
            result[p] = [];
        }
        result[p].push(people[i]);
    }
    return result;
}