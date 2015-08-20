window.onload = function () {
    var paper = Raphael(10, 10, 500, 500);
    var center = {
            x: paper.width / 2,
            y: paper.height / 2
        },
        radius = 45,
        angle = 0,
        point = {
            radius: 1,
            x: 0,
            y: 0
        },
        pointsCount = 1,
        maxRotations = 3.25;

    function drawPoint(paper, x, y, r) {
        paper.circle(x, y, r);
    }

    function movePoint(trajectory) {
        return {
            x: trajectory.x + trajectory.radius * Math.sin(trajectory.angle),
            y: trajectory.y + trajectory.radius * Math.cos(trajectory.angle)
        };
    }

    function drawSpiral() {
        for (var rotation = 0; rotation < maxRotations;) {
            angle += 0.01;
            rotation = angle / (2 * Math.PI);
            for (var i = 0; i < pointsCount; i += 1) {
                var newPoint = movePoint({
                    x: center.x,
                    y: center.y,
                    radius: radius * rotation,
                    angle: angle + i * 2 * Math.PI / pointsCount
                });
                drawPoint(paper, newPoint.x, newPoint.y, point.radius);
            }
        }
    }

    drawSpiral();
};