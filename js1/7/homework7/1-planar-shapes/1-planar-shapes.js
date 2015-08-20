function initializeScript(action, lineNumber) {
    "use strict";
    switch (action) {
    case 'getDistance':
        //var points = document.getElementById('linePoints').replace(/\s+/g, '').split(',');
        var line = getLine(lineNumber);

        jsConsole.writeLine('Line ' + lineNumber + ' length: ' + line.length());
        break;
    case 'canFormTriangle':
        var allLines = [],
            i;

        for (i = 0; i < 3; i += 1) {
            allLines[i] = getLine(i);
        }

        jsConsole.writeLine('The lines can form a triangle: ' + canFormTriangle(allLines[0], allLines[1], allLines[2]));
        break;
    }
}

function getLine(lineNumber) {
    //must use all possible functions!!!
    var startPointCoords = document.getElementById('startPointCoords' + lineNumber).value.replace(/\s+/g, '').split(','),
        endPointCoords = document.getElementById('endPointCoords' + lineNumber).value.replace(/\s+/g, '').split(','),

        point2 = makePoint(endPointCoords[0], endPointCoords[1]),
        point1 = makePoint(startPointCoords[0], startPointCoords[1]);
    return makeLine(point1, point2);
}

function makePoint(x, y) {
    return {
        x: x,
        y: y
    };
}

function makeLine(point1, point2) {
    return {
        point1: point1,
        point2: point2,
        length: function () {
            return getDistance(point1, point2);
        }
    };
}

function getDistance(point1, point2) {
    var dx = point1.x - point2.x,
        dy = point1.y - point2.y;
    return Math.sqrt(dx * dx + dy * dy);
}

function canFormTriangle(line1, line2, line3) {
    var a = getDistance(line1.point1, line1.point2),
        b = getDistance(line2.point1, line2.point2),
        c = getDistance(line3.point1, line3.point2);

    if (a + b > c && a + c > b && b + c > a) {
        return true;
    } else {
        return false;
    }
}