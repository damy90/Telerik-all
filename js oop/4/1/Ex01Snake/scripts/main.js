/// <reference path="snake.js" />
/// <reference path="canvastools.js" />

//the playing field is a matrix of 10x10 where each Unit of the snake, or a food takes up a single square
//on a 500px by 500px canvas each square is
var GRID_SIZE = 50;
var instanceOfSnake = new snake.Snake();
shapeDrawer.setContext('foreground');
alert('Use Arrow keys to move the snake around');

function printSnake(unitList){
    shapeDrawer.Clear();
    var head = unitList[0];
    shapeDrawer.Circle(head.x, head.y, 25);
    for(var i = 1; i < unitList.length; i++){
        var unit = unitList[i];
        shapeDrawer.Circle(unit.x, unit.y, 20);
    }
};

function arrowMoveSnake(e){
    //console.log(e);
    var direction = 'none';
    if (e.keyIdentifier === 'Down') {
        direction = 'down';
    }
    else if (e.keyIdentifier === 'Right') {
        direction = 'right';
    }
    else if (e.keyIdentifier === 'Left') {
        direction = 'left';
    }
    else if (e.keyIdentifier === 'Up') {
        direction = 'up';
    }
    instanceOfSnake.advance(direction);
    printSnake(instanceOfSnake.unitsOnGrid(GRID_SIZE));
};

document.addEventListener("keyup", arrowMoveSnake);

