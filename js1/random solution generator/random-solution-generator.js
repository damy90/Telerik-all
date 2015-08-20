/*jslint unparam: true */
function Solve(args) {
    // ['string', 'string'] - variants
    // [0, 1000] - number range
    var stringParams1 = ['out ', 'lost '],
        stringParams2 = [0, 500];
    return randomStringGenerator([stringParams1, stringParams2]);

    function randomStringGenerator(stringParams) {
        var result = '',
            randomChoice, i;
        for (i in stringParams) {
            // number range
            if (stringParams[i].length === 2 && isFinite(stringParams[i][0]) && isFinite(stringParams[i][1])) {
                randomChoice = randomizer(undefined, stringParams[i][0], stringParams[i][1]);
                result += randomChoice;
            }
            // variants
            else {
                randomChoice = randomizer(stringParams[i].length);
                result += stringParams[i][randomChoice];
            }
        }
        return result;
    }

    function randomizer(paramsCount, startRange, endRange) {
        paramsCount = paramsCount || Math.abs(endRange - startRange);
        startRange = startRange || 0;

        return Math.floor(Math.random() * paramsCount) + startRange;
    }
}

console.log(Solve('test'));