var canvas = document.getElementById("drawing-shapes"),
    ctx = canvas.getContext("2d");

var Shapes = (function () {
    var Shape = (function () {
        function Shape(x, y) {
            this._x = x;
            this._y = y;
        }

        return Shape;
    })();

    var Rect = (function () {
        function Rect(x, y, width, height) {
            Shape.call(this, x, y);
            this._width = width;
            this._height = height;
        }

        Rect.prototype = new Shape();

        Rect.prototype.draw = function () {
            ctx.strokeRect(this._x, this._y, this._width, this._height);
        };

        return Rect;
    })();

    var Circle = (function () {
        function Circle(x, y, radius) {
            Shape.call(this, x, y);
            this._radius = radius;
        }

        Circle.prototype = new Shape();

        Circle.prototype.drawCircle = function () {
            ctx.arc(this._x, this._y, this._radius, 0, 2 * Math.PI);
            ctx.stroke();
        };

        return Circle;
    })();

    var Line = (function () {
        function Line(x, y, x2, y2) {
            Shape.call(this, x, y);
            this._x2 = x2;
            this._y2 = y2;
        }

        Line.prototype = new Shape();

        Line.prototype.drawLine = function () {
            ctx.moveTo(this._x, this._y);
            ctx.lineTo(this._x2, this._y2);
            ctx.stroke();
        };

        return Line;
    })();

    return {
        //Shape: Shape,
        Rect: Rect,
        Circle: Circle,
        Line: Line
    };

})();

var rect = new Shapes.Rect(40, 70, 100, 100);
rect.draw();

var circle = new Shapes.Circle(90, 120, 45);
circle.drawCircle();

var line = new Shapes.Line(0, 0, 800, 400);
line.drawLine();