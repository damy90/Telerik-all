(function () {
    var $guess = $('#guess');
    var $win = $('#win');
    var $scoreboard = $('#scoreboard');
    var $showScoreboardButton = $('#show-scoreboard');
    var $hideScoreboardButton = $('#hide-scoreboard');
    var $scoreList = $scoreboard.find('ul');
    var randomNumber, atempts;

    restart();
    generateScoreboard();
    hideScoreboard();

    $guess.on('click', 'button', numberInput);
    $showScoreboardButton.on('click', showScoreboard);
    $hideScoreboardButton.on('click', hideScoreboard);

    $win.on('click', 'button', function () {
        var name = $('#score').val();
        if (name === null || name === '') {
            alert('Nick name cannot be empty!');
            return;
        }
        localStorage.setItem(name, atempts);
        generateScoreboard();

        restart();
    });

    function restart() {
        $win.hide();
        $guess.show();
        randomNumber = getRandomNumber(1000, 9999).toString().split('');
        atempts = 0;
    }

    function generateScoreboard() {
        $scoreList.empty();
        for (var player in localStorage) {
            var $playerEntry = $('<li>').text('player: ' + player + ', score: ' + localStorage[player])
                .appendTo($scoreList);
        }
    }

    function showScoreboard() {
        $showScoreboardButton.hide();
        $hideScoreboardButton.show();
        $scoreboard.show();
    }

    function hideScoreboard() {
        $showScoreboardButton.show();
        $hideScoreboardButton.hide();
        $scoreboard.hide();
    }

    function numberInput() {
        var inputNumber = $('#inputNumber').val();

        if (!isValidNumber(inputNumber)) {
            alert('Number must be a decimal value between 1000 and 9999');
            return;
        }

        atempts += 1;
        var result = guessNumber(inputNumber);
        console.log('Input number: ' + inputNumber);

        if (result.rams === 4) {
            $guess.hide();
            $win.find('legend').text('You win in ' + atempts + ' atempts!');
            $win.show();
            return;
        }

        alert('Sheep: ' + result.sheep + ' Rams: ' + result.rams);
    }

    function isValidNumber(n) {
        n = parseFloat(n);
        var isNumber = !isNaN(n) && isFinite(n);
        var isValid = (n - Math.round(n) === 0) && n >= 1000 && n <= 9999;
        return isNumber && isValid;
    }

    function getRandomNumber(startRange, endRange) {
        startRange = startRange || 0;
        endRange = endRange || 1;
        var paramsCount = Math.abs(endRange - startRange);
        var result = Math.floor(Math.random() * paramsCount) + startRange;

        console.log('Random number: ' + result);

        return result;
    }

    function guessNumber(number) {
        number = number.toString().split('');
        var sheep = 0;
        var rams = 0;
        var i;
        var indexOfDidgit = 0;
        var length = number.length;
        for (i = 0; i < length; i++) {
            if (randomNumber[i] === number[i]) {
                rams += 1;
                continue;
            }

            indexOfDidgit = randomNumber.indexOf(number[i]);
            if (indexOfDidgit !== -1) {
                sheep += 1;
            }
        }

        return {
            sheep: sheep,
            rams: rams
        };
    }
})();