function solve(args) {
    var col = 0,
        row = 0;
    var matrix = args.slice(1).map(function (line) {
        return line.split(' ');
    });
    var directions = {
        d: 1,
        u: -1,
        r: 1,
        l: -1
    };
    var exited = false;
    var score = 0;
    var visitedCells = {};

    while (1) {
        //exit, visited
        var key = row + ';' + col;
        if (visitedCells[key]) {
            break;
        }

        if (!(matrix[row] && matrix[row][col])) {
            exited = true;
            break;
        }

        visitedCells[key] = true;
        //add score
        score += (1 << row) + col;
        //move
        var command = matrix[row][col].split('');
        row += directions[command[0]];
        col += directions[command[1]];
    }

    if (exited) {
        //USE SPELCHECK NEXT TIME!!!!
        console.log('successed with ' + score);
    } else {
        console.log('failed at (' + row + ', ' + col + ')');
    }
}

var args1 = [
 '3 5',
 'dr dl dr ur ul',
 'dr dr ul ur ur',
 'dl dr ur dl ur'
];

var args2 = [
 '3 5',
 'dr dl dl ur ul',
 'dr dr ul ul ur',
 'dl dr ur dl ur'
];

solve(args1);
solve(args2);