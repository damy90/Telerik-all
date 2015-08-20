function Solve(args) {
    var playfield = args[0].split(' ').map(Number),
        rows = playfield[0], //M
        cols = playfield[1]; //N

    var temp = args[1].split(' ').map(Number);
    var pos = {
        row: temp[0],
        col: temp[1]
    };

    var directions = {
        l: {
            row: 0,
            col: -1
        },
        r: {
            row: 0,
            col: 1
        },
        u: {
            row: -1,
            col: 0
        },
        d: {
            row: 1,
            col: 0
        }
    };

    // Good example for bad naming. Contains directions for each cell or true if the cell was visited. Also 2D is 1 dimencion too much!
    var magickArray = (args.slice(2)).join('').split('');

    // 1D index
    function index(pos) {
        return pos.row * cols + pos.col;
    }

    var mooves = 0,
        points = 0; //visited
    while (true) {
        var justVisitedIndex = index(pos);

        if (pos.row < 0 || pos.row >= rows || pos.col < 0 || pos.col >= cols) {
            return 'out ' + points;
        }

        if (magickArray[justVisitedIndex] === true) {
            return 'lost ' + mooves;
        }

        points += justVisitedIndex + 1;

        var command = magickArray[justVisitedIndex];
        pos.col += directions[command].col;
        pos.row += directions[command].row;
        mooves++;
        magickArray[justVisitedIndex] = true;
    }
}

var args = [];

args = [
    "3 4",
    "1 3",
    "lrrd",
    "dlll",
    "rddd"
];

console.log(Solve(args));

args = [
    '32 6',
    '8 0',
    'lduldu',
    'ludllr',
    'lrurlr',
    'drlruu',
    'llldrr',
    'ddllrr',
    'lrlruu',
    'luulrd',
    'lurlur',
    'lulrru',
    'llulll',
    'lrrrll',
    'udduld',
    'ddudrl',
    'ruludl',
    'luruul',
    'ddddrr',
    'luluru',
    'uudlru',
    'ddudlu',
    'durllu',
    'ldlrul',
    'rrdurd',
    'dlrrdl',
    'lrrdlu',
    'rruudl',
    'rrdudu',
    'dudrlr',
    'lllldr',
    'uluudl',
    'rdurru',
    'ulurud'

];

console.log(Solve(args));