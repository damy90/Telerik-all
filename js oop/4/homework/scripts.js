$(document).ready(function () {
    //Canvas stuff
    var canvas = $("#canvas")[0];
    var ctx = canvas.getContext("2d");
    var width = $("#canvas").width();
    var heigth = $("#canvas").height();

    var cellSize = 10;
    var direction;
    var food;
    var score;

    var snakeArray; //an array of cells to make up the snake
    var game_loop;

    function init() {
        direction = "right"; //default direction
        snakeArray = createSnake();
        food = createFood(); 
        score = 0;

        //Lets move the snake now using a timer which will trigger the paint function every 60ms
        if (typeof game_loop != "undefined") {
            clearInterval(game_loop);
        }
        game_loop = setInterval(paint, 60);
    }
    init();

    function createSnake() {
        var _length = 5;
        var _snake_array = [];
        //This will create a horizontal snake starting from the top left
        for (var i = _length - 1; i >= 0; i--) {   
            _snake_array.push({
                x: i,
                y: 0
            });
        }
        return _snake_array;
    }

    function createFood() {
        var _x = Math.round(Math.random() * (width - cellSize) / cellSize),
            _y = Math.round(Math.random() * (heigth - cellSize) / cellSize);

        return {
            x: _x,
            y: _y
        };
    }

    function paint() {
        //To avoid the snake trail we need to paint the BG on every frame
        ctx.fillStyle = "white";
        ctx.fillRect(0, 0, width, heigth);
        ctx.strokeStyle = "black";
        ctx.strokeRect(0, 0, width, heigth);

        //The movement code for the snake to come here.
        //Pop out the tail cell and place it infront of the head cell
        var nx = snakeArray[0].x;
        var ny = snakeArray[0].y;
        //These were the position of the head cell.
        //We will increment it to get the new head position
        if (direction == "right") nx++;
        else if (direction == "left") nx--;
        else if (direction == "up") ny--;
        else if (direction == "down") ny++;

        //This will restart the game if the snake hits the wall or the head of the snake bumps into its body, the game will restart
        if (nx == -1 || nx == width / cellSize || ny == -1 || ny == heigth / cellSize || checkCollision(nx, ny, snakeArray)) {
            //restart game
            init();
            return;
        }

        var tail;
        if (nx == food.x && ny == food.y) {
            tail = {
                x: nx,
                y: ny
            };
            score++;
            food = createFood();
        } else {
            tail = snakeArray.pop(); //pops out the last cell
            tail.x = nx;
            tail.y = ny;
        }
        //The snake can now eat the food.

        snakeArray.unshift(tail); //puts back the tail as the first cell

        for (var i = 0; i < snakeArray.length; i++) {
            var c = snakeArray[i];
            paintCell(c.x, c.y);
        }

        paintCell(food.x, food.y);
        var scoreText = "Score: " + score;
        ctx.fillText(scoreText, 5, heigth - 5);
    }

    function paintCell(x, y) {
        ctx.fillStyle = "blue";
        ctx.fillRect(x * cellSize, y * cellSize, cellSize, cellSize);
        ctx.strokeStyle = "white";
        ctx.strokeRect(x * cellSize, y * cellSize, cellSize, cellSize);
    }

    function checkCollision(x, y, array) {
        //This function will check if the provided x/y coordinates exist in an array of cells or not
        for (var i = 0; i < array.length; i++) {
            if (array[i].x == x && array[i].y == y)
                return true;
        }
        return false;
    }

    $(document).keydown(function (e) {
        var key = e.which;
        //I will add another clause to prevent reverse gear
        if (key == "37" && direction != "right") direction = "left";
        else if (key == "38" && direction != "down") direction = "up";
        else if (key == "39" && direction != "left") direction = "right";
        else if (key == "40" && direction != "up") direction = "down";
    });
});