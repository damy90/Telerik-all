function Solve(args) {
    for (var i in args) {
        args[i] = args[i].split(' ').map(Number);
    }

    var initialize = args[0],
        colsCount = initialize[1], //M
        rowsCount = initialize[0], //N
        jumps = initialize[2];

    var pos = {
        row: args[1][1],
        col: args[1][0]
    };

    var jumpsArr = args.slice(2);

    function index(pos) {
        return pos.row * colsCount + pos.col;
    }

    var escaped = false,
        caught = false,
        jumpsCount = 0,
        points = 0;

    var visited = new Array(rowsCount * colsCount);

    i = 0;
    while (true) {
        //for (i = 0; i <= jumps; i++) {

        if (pos.row < 0 || pos.row >= rowsCount || pos.col < 0 || pos.col >= colsCount) {
            escaped = true;
            break;
        }
        if (visited[index(pos)]) {
            caught = true;
            break;
        }

        jumpsCount++;
        visited[index(pos)] = true;

        points += index(pos) + 1;

        //        console.log("r:" + pos.row + " c:" + pos.col);
        //        console.log(index(pos));
        //        console.log("---" + points);

        var jump = {
            col: jumpsArr[i][1],
            row: jumpsArr[i][0]
        };
        pos.col += jump.col;
        pos.row += jump.row;
        i++;
        if (i >= jumps)
            i = 0;

        //}

    }

    if (escaped) {
        console.log('escaped ' + points);
    } else {
        console.log('caught ' + jumpsCount);
    }
}

var input = [
        '6 7 3',
        '0 0',
        '2 2',
        '-2 2',
        '3 -1'
    ];

Solve(input);

var input = [
    '150 200 6',
    '2 2',
    '5 100',
    '20 -97',
    '50 50',
    '-60 0',
    '100 20',
    '-98 -30'

];

Solve(input);