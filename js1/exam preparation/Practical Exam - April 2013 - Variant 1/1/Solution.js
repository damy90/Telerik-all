function Solve(params) {
    var N = parseInt(params[0]);
    var answer = 1;

    for (var i = 2; i < N + 1; i++) {
        if (parseInt(params[i - 1]) > parseInt(params[i])) {
            answer++;
        }
    }
    return answer;
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