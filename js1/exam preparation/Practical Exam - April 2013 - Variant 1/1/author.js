function Solve(params) {
    var N = parseInt(params[0]);
    var count = 1;
    var last = parseInt(params[1]);
    for (var i = 2; i <= N; i++) {
        var current = parseInt(params[i]);
        if (current < last) {
            count++;
        }
        last = current;
    }
    return count;
}

var input = [
    7, 1, 2, -3, 4, 4, 0, 1

];

console.log(Solve(input));

input = [
    7,
    1,
    2, -3,
    4,
    4,
    0,
    1

];
console.log(Solve(input));

input = [
    6,
    1,
    3,
    -5,
    8,
    7,
    -6
];
console.log(Solve(input));

input = [
    9,
    1,
    8,
    8,
    7,
    6,
    5,
    7,
    7,
    6
];
console.log(Solve(input));