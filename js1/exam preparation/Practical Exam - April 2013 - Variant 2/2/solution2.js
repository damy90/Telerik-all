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
    var cellArray = args.slice(2);

    for (var i in cellArray) {
        cellArray[i] = cellArray[i].split('');
    }

    // 1D index
    function getPoints(pos) {
        return pos.row * cols + pos.col + 1;
    }

    var mooves = 0,
        points = 0; //visited
    while (true) {
        if (pos.row < 0 || pos.row >= rows || pos.col < 0 || pos.col >= cols) {
            return 'out ' + points;
        }

        if (cellArray[pos.row][pos.col] === true) {
            return 'lost ' + mooves;
        }

        var justVisitedIndex = [pos.row, pos.col];

        points += getPoints(pos);
        var command = cellArray[pos.row][pos.col];

        pos.col += directions[command].col;
        pos.row += directions[command].row;
        mooves++;
        cellArray[justVisitedIndex[0]][justVisitedIndex[1]] = true;
    }
}


//var args = [
//    "3 4",
//    "1 3",
//    "lrrd",
//    "dlll",
//    "rddd"
//];
//
//
//console.log(Solve(args));
var args1 = [
    "5 8",
    "0 0",
    "rrrrrrrd",
    "rludulrd",
    "durlddud",
    "urrrldud",
    "ulllllll"
];
console.log(Solve(args1));