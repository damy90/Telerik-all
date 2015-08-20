define(['jquery'], function ($) {
    var UI = (function () {
        function buildGameField(gameFieldString) {
            var cels = gameFieldString.split('');
            var $cel = $('<button></button>').attr("class", "cel");
            var row = 1;
            var col = 1;
            for (var cel in cels) {
                $cel = $cel.clone();
                $cel.attr("data-row", row).attr("data-col", col).text(cels[cel] === '-' ? '' : cels[cel]);
                col++;
                if (col > 3) {
                    col = 1;
                    row++;
                }
                $cel.appendTo($('#game-field'));
            }
        }

        return {
            buildGameField: buildGameField,
        };
    }());

    return UI;
});