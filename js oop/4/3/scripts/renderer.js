/// <reference path="_reference.js" />

var Renderer = (function () {
    function CanvasRenderer(selector) {
        if (selector instanceof HTMLCanvasElement) {
            this.canvas = selector;
        }
        else if (typeof selector === 'String' || typeof selector === 'string') {
            this.canvas = document.querySelector(selector);
        }
    }

    CanvasRenderer.prototype.draw = function (obj) {
        if (obj instanceof Snake.SnakeBody) {
            drawSnake(this.canvas, obj);
        }
        else if (obj instanceof Snake.SnakePart) {
            drawSnakePart(this.canvas, obj);
        }
        else if (obj instanceof Food.Apple) {
            drawFood(this.canvas, obj);
        }
        else if (obj instanceof Texts.Text) {
            drawText(this.canvas, obj);
        }
    }

    CanvasRenderer.prototype.clear = function () {
        var ctx = this.canvas.getContext('2d');
        var width = this.canvas.width;
        var height = this.canvas.height;
        ctx.clearRect(0, 0, width, height);
    }

    CanvasRenderer.prototype.getDimensions = function () {
        return {
            minWidth: 0,
            maxWidth: this.canvas.width,
            minHeight: 0,
            maxHeight: this.canvas.height
        };
    }

    var drawSnake = function (canvas, snake) {
        for (var i = 0; i < snake.parts.length; i++) {
            drawSnakePart(canvas, snake.parts[i]);
        }
    }

    var drawSnakePart = function (canvas, part) {
        var ctx = canvas.getContext('2d');

        if (part instanceof Snake.SnakeHead) {
            ctx.fillStyle = 'orange';
            ctx.strokeStyle = 'black';
        }
        else if (part instanceof Snake.SnakePart) {
            ctx.fillStyle = '#aace00';
            ctx.strokeStyle = 'black';
        }

        var position = part.getPosition();
        ctx.fillRect(position.x, position.y, part.size, part.size);
        ctx.strokeRect(position.x, position.y, part.size, part.size);
    }

    var drawFood = function (canvas, food) {
        var ctx = canvas.getContext('2d');
        ctx.fillStyle = 'red';
        ctx.strokeStyle = 'black';
        var position = food.getPosition();
        ctx.beginPath();
        ctx.arc(position.x, position.y, food.size, 0, 2 * Math.PI);
        ctx.fill();
        ctx.stroke();
    }

    var drawText = function (canvas, text) {
        var ctx = canvas.getContext('2d');
        ctx.font = 'bold 16px sans-serif';
        ctx.fillStyle = '#ffffff';
        ctx.textAlign = 'center';
        ctx.textBaseline = 'middle';
        var position = text.getPosition();
        ctx.fillText(text.label + ' ' + text.number, position.x, position.y);
    }

    

    return {
        CanvasRenderer: CanvasRenderer
    };
})();