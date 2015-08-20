function isInside() {
    "use strict";
    var x = jsConsole.readFloat("#x"), 
        y = jsConsole.readFloat("#y"),
        radius = 5,
        distanceFromCenter = Math.pow((x * x + y * y), 0.5);

    jsConsole.writeLine("The point is within the circle: " + (distanceFromCenter <= radius));
}