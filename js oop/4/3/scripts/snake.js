/// <reference path="_reference.js" />

var Snake = (function () {
    var SNAKE_PART_WIDTH = 15;

    var directions = [
        { dx: -1, dy: 0 }, // left -> 0
        { dx: 0, dy: -1 }, // up -> 1
        { dx: +1, dy: 0 }, // right -> 2
        { dx: 0, dy: +1 } // down -> 3
    ]

    /*
     * SnakePart is separate elements of snake
     */
    function SnakePart(x, y, size) {
        GameObject.Part.call(this, x, y, size);
    }

    SnakePart.prototype = new GameObject.Part();
    SnakePart.prototype.constructor = SnakePart;
    SnakePart.prototype.changePosition = function (x, y) {
        this.x = x;
        this.y = y;
    }

    /*
     * SnakeHead
     */
    function SnakeHead(x, y, size) {
        SnakePart.call(this, x, y, size);
    }

    SnakeHead.prototype = new SnakePart();
    SnakeHead.prototype.constructor = SnakeHead;

    /*
     * Snake - combine all SnakePart + SnakeHead
     */
    function SnakeBody(x, y, size) {
        var part = null,
            partX,
            partY;

        this.parts = [];
        this.direction = 2; // default position right
        this.size = size;

        part = new SnakeHead(x, y, SNAKE_PART_WIDTH);
        this.parts.push(part);

        for (var i = 1; i < this.size; i++) {
            partX = x - i * SNAKE_PART_WIDTH;
            partY = y;
            part = new SnakePart(partX, partY, SNAKE_PART_WIDTH);
            this.parts.push(part);
        }
    }

    SnakeBody.prototype = new GameObject.Part();
    SnakeBody.prototype.constructor = SnakeBody;

    SnakeBody.prototype.head = function () {
        return this.parts[0];
    }

    SnakeBody.prototype.size = function () {
        return this.size;
    }

    SnakeBody.prototype.move = function () {
        var dx,
            dy,
            i,
            position,
            head,
            headPosition,
            newHeadPosition;

        for (i = this.parts.length - 1; i >= 1; i--) {
            position = this.parts[i - 1].getPosition();
            this.parts[i].changePosition(position.x, position.y);
        }

        head = this.head();
        dx = directions[this.direction].dx;
        dy = directions[this.direction].dy;
        headPosition = head.getPosition();
        newHeadPosition = {
            x: headPosition.x + head.size * dx,
            y: headPosition.y + head.size * dy
        };
        head.changePosition(newHeadPosition.x, newHeadPosition.y);
    }

    SnakeBody.prototype.changeDirection = function (newDirection) {
        if (newDirection >= 0 && newDirection < directions.length && (this.direction + newDirection) % 2) {
            this.direction = newDirection;
        }
    }

    SnakeBody.prototype.getPosition = function () {
        return this.head().getPosition();
    }

    SnakeBody.prototype.changePosition = function (x, y) {
        this.head().changePosition(x, y);
    }

    return {
        SnakeBody: SnakeBody,
        SnakePart: SnakePart,
        SnakeHead: SnakeHead
    };
})();