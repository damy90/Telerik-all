function Solve(args) {
    for (var i in args) {
        args = args.map(Number);
    }

    var numbersCount = args[0]; //N
    var numbers = args.slice(1);
    var maxSum = numbers[0]; //Number.MIN_VALUE
    for (i = 0; i < numbersCount; i++) {
        var sum = 0;
        maxSum = Math.max(sum, maxSum);
        for (var j = i; j < numbersCount; j++) {
            sum += numbers[j];
            maxSum = Math.max(sum, maxSum);
        }
    }
    return maxSum;
}

var args = [
    '8',
    '1',
    '6',
    '-9',
    '4',
    '4',
    '-2',
    '10',
    '-1'
];

console.log(Solve(args));

args = [
    '6',
    '1',
    '3',
    '-5',
    '8',
    '7',
    '-6'
];

console.log(Solve(args));

args = [
    '9',
    '-9',
    '-8',
    '-8',
    '-7',
    '-6',
    '-5',
    '-1',
    '-7',
    '-6'
];

console.log(Solve(args));