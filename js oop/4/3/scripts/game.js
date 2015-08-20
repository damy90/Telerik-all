/// <reference path="_reference.js" />

var Games = (function () {
    'use strict';
    var gameSpeed = 150;
    var snakePartSize;
    var partNumbers = 5;
    var foodSize = 10;
    var gamePoints = 1;
    var theGame;
    var dimensions;

    function SnakeGame(renderer) {
        this.renderer = renderer;
        this.snake = new Snake.SnakeBody(250, 250, partNumbers);
        snakePartSize = this.snake.parts[0].size;
        this.food = new Food.Apple(400, 250, foodSize);
        this.points = new Texts.Text((this.renderer.canvas.clientWidth / 2), 20, 'Points', gamePoints);
        this.gameEnd = new Texts.Text((this.renderer.canvas.clientWidth / 2), (this.renderer.canvas.clientHeight / 2), 'GAME OVER YOU MADE: ', gamePoints);
        this.bindKeyEvents();
        this.state = 'start';
    }

    SnakeGame.prototype.start = function () {
        theGame = this;
        setTimeout(animationFrame, gameSpeed);
        dimensions = this.renderer.getDimensions();
        this.state = 'running';
    }

    SnakeGame.prototype.stop = function () {
        theGame.state = 'stopped';
    }

    SnakeGame.prototype.pause = function () {
        theGame.state = 'pause';
    }

    SnakeGame.prototype.bindKeyEvents = function () {
        var self = this;

        document.body.addEventListener('keydown', function (ev) {
            var keyCode = ev.keyCode;

            if (37 <= keyCode && keyCode <= 40) {
                self.snake.changeDirection(keyCode - 37);
            }

            if (keyCode === 32) {
                if (theGame.getState() === 'pause') {
                    theGame.state = 'running';
                    theGame.start();
                }
                else {
                    theGame.pause();
                }
            }
        });
    }

    SnakeGame.prototype.getState = function () {
        return this.state;
    }

    SnakeGame.prototype.changeRenderer = function (newRenderer) {
        this.renderer = newRenderer;
    }

    function random(low, high) {
        var min = low;
        var max = high;
        var rand = Math.floor((Math.random() * 30) + 1);
        var result = rand * low;

        while (result >= max) {
            result -= min;
        }

        return result;
    }

    function biteSnakeAss() {
        var i,
                len,
                headPartPosition,
                bodyPartPosition;

        headPartPosition = theGame.snake.parts[0].getPosition();

        for (i = 1, len = theGame.snake.parts.length; i < len; i++) {

            bodyPartPosition = theGame.snake.parts[i].getPosition();

            if (headPartPosition.x === bodyPartPosition.x && headPartPosition.y === bodyPartPosition.y) {
                return true;
            }
        }

        return false;
    }

    function displayGameOver() {
        theGame.gameEnd.number = theGame.points.number + ' ' + ' POINTS. Press F5 to start again';
        theGame.renderer.draw(theGame.gameEnd);
    }

    function animationFrame() {
        var snakePosition = theGame.snake.getPosition(),
			newX = snakePosition.x,
			newY = snakePosition.y;

        var foodPosition = theGame.food.getPosition();

        // Increase points
        if (foodPosition.x === snakePosition.x && foodPosition.y === snakePosition.y ||
            foodPosition.x - snakePartSize === snakePosition.x && foodPosition.y - snakePartSize === snakePosition.y ||
            foodPosition.x - 5 === snakePosition.x && foodPosition.y - 5 === snakePosition.y) {
            theGame.points.number++;
            theGame.snake.size++;
            var lastPart = theGame.snake.parts[theGame.snake.parts.length - 1];
            var snakeSize = lastPart.size;
            var newPart = new Snake.SnakePart(lastPart.x - snakeSize, lastPart.y, snakeSize);
            theGame.snake.parts.push(newPart);
            theGame.food.setPosition(random(snakePartSize, theGame.renderer.canvas.clientWidth - snakePartSize), random(snakePartSize, theGame.renderer.canvas.clientWidth - snakePartSize));

            // Increase speed
            if (gameSpeed !== 0) {
                gameSpeed -= 1;
            }
        }

        // Out of field
        if (snakePosition.x <= 0
            || snakePosition.y <= 0
            || snakePosition.x >= theGame.renderer.canvas.clientWidth - snakePartSize
            || snakePosition.y >= theGame.renderer.canvas.clientHeight - snakePartSize
            ) {
            theGame.state = 'stopped';
        }

        // Bite my ass I hate games and need to stop
        if (biteSnakeAss()) {
            theGame.state = 'stopped';
        }

        theGame.snake.changePosition(newX, newY);
        theGame.renderer.clear();
        theGame.snake.move();

        theGame.renderer.draw(theGame.snake);
        theGame.renderer.draw(theGame.food);
        theGame.renderer.draw(theGame.level);
        theGame.renderer.draw(theGame.points);

        if (theGame.getState() === 'stopped') {
            displayGameOver();
        }

        if (theGame.getState() === 'running') {
            setTimeout(animationFrame, gameSpeed);
        }
    }

    return {
        SnakeGame: SnakeGame
    };
})();