function Solve(args) {
    var wordLength = parseInt(args[0]),
        crossword = args.slice(1);

    var result = [],
        verticalWord;
    for (var col in crossword) {
        for (var row = 0; row < crossword.length - wordLength; row++) {
            verticalWord = '';
            for (var leter = 0; leter < wordLength; leter++) {
                verticalWord += crossword[row + leter][col];
            }
            if (crossword.indexOf(verticalWord) != -1) {
                result.push(verticalWord);
                console.log(verticalWord);
            }
        }
    }
    if (result.length === 0) {
        console.log('NO SOLUTION!');
    }
}

var args = [
    4,
    'FIRE',
    'ACID',
    'CENG',
    'EDGE',
    'FACE',
    'ICED',
    'RING',
    'CERN'
];

console.log(Solve(args));

var args1 = [
    3,
    'ABC',
    'DEF',
    'GHI',
    'JKL',
    'MNO',
    'PQR'
];

console.log(Solve(args1));