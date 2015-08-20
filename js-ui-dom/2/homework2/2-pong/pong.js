var canvas = document.getElementById('the-canvas');
var context = canvas.getContext("2d");
var x = 100,
    y = 50,
    dx = 1,
    dy = 1,
    radius = 8;
setInterval(move, 10);

function move() {
    context.clearRect(0, 0, canvas.width, canvas.height);

    x += dx;
    y += dy;
    if (x === radius || x === canvas.width - radius) {
        dx *= -1;
    }
    if (y === radius || y === canvas.height - radius) {
        dy *= -1;
    }

    context.beginPath();
    context.arc(x, y, radius, 0, 2 * Math.PI);
    context.fillStyle = "black";
    context.fill();
}