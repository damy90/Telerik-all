var DrawModule = function(canvasId){
    var ctx = document.getElementById(canvasId).getContext('2d');

    var rect = function(x, y, width, height){
        ctx.beginPath();
        ctx.rect(x, y, width, height);
        ctx.strokeStyle = getRandomColor();
        ctx.fillStyle = getRandomColor();
        ctx.stroke();
        ctx.fill();
    }

    var circle = function(x, y, radius){
        ctx.beginPath();
        ctx.arc(x, y, radius, 0, 2 * Math.PI);
        ctx.strokeStyle = getRandomColor();
        ctx.fillStyle = getRandomColor();
        ctx.fill();
        ctx.stroke();
    }

    var line = function(x1, y1, x2, y2){
        ctx.beginPath();
        ctx.moveTo(x1, y1);
        ctx.lineTo(x2, y2);
        ctx.strokeStyle = getRandomColor();
        ctx.stroke();
    }

    function getRandomNumber(max){
        return Math.floor(Math.random() * max);
    }

    function getRandomColor(){
        var red = getRandomNumber(256);
        var green = getRandomNumber(256);
        var blue = getRandomNumber(256);

        return 'rgb(' + red + ',' + green + ',' + blue + ')'
    }

    return{
        rect : rect,
        circle : circle,
        line : line
    }
};
