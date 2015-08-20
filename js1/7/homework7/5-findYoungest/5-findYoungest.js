function testFindYoungest() {
    var people = [
            {
                firstName: 'Gosho',
                lastName: 'Petrov',
                age: 32
            },
            {
                firstName: 'Bay',
                lastName: 'Ivan',
                age: 81
            },
        ],
        i;

    jsConsole.writeLine('Everyone:');
    for (i in people) {
        jsConsole.writeLine(people[i].firstName + ' ' + people[i].lastName + ', Age: ' + people[i].age);
    }
}

function findYoungest(people) {
    var youngestPersonPosition,
        youngestPersonAge = Number.MAX_VALUE,
        youngestPerson,
        i;

    for (i in people) {
        if (people[i].age < youngestPersonAge) {
            youngestPersonAge = people[i].age;
            youngestPersonPosition = i;
        }
    }

    youngestPerson = people[youngestPersonPosition];
    jsConsole.writeLine('The Youngest person is: ' + youngestPerson.firstName + ' ' + youngestPerson.lastName + ', Age: ' + youngestPerson.age);
}