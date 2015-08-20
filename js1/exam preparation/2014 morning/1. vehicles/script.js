function solve(params) {
    var s = +params[0];
    var count = 0;
    var i,
        j,
        k;

    for (i = 0; i <= s / 10; i++) {
        for (j = 0; j <= s / 4; j++) {
            for (k = 0; k <= s / 3; k++) {
                if (i * 10 + j * 4 + k * 3 === s) {
                    count++;
                }
            }
        }
    }
    console.log(count);
}

var test = ["7"];
solve(test);