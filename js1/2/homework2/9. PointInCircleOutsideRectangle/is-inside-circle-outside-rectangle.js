function isInsideCircleOutsideRect() {
    "use strict";
    var x = jsConsole.readFloat("#x"),
        y = jsConsole.readFloat("#y");

    var circleRadius = 3,
        circleX = 1,
        circleY = 1;
    var rectTop = 1,
        rectLeft = -1,
        rectBottom = -1,
        rectRight = 5;

    var insideRect = x >= rectLeft && x <= rectRight && y <= rectTop && y >= rectBottom;

    var xCenterDist = circleX - x,
        yCenterDist = circleY - y,
        dist = Math.sqrt(xCenterDist * xCenterDist + yCenterDist * yCenterDist);

    var insideCircle = dist <= circleRadius;

    jsConsole.writeLine("The point is within the circle and outside the rectangle: " + ((!insideRect) && insideCircle));
}