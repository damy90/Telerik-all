window.onload = function() {
    var canvas = document.getElementById('field'),
        ctx = canvas.getContext('2d'),
        center = {
            x: canvas.width / 2,
            y: canvas.height / 2
        },
        radius = 100,
        angle = 0,
        point = {
            radius: 30,
            x: 0,
            y: 0
        };
    var el = document.getElementById('c');
    var ctx2 = el.getContext('2d');

    var clicked = false;

    el.onmousedown = function(e) {
        console.log(e.x);
        console.log(e.y);
        clicked = true;
        ctx2.lineWidth = 2;
        ctx2.lineJoin = ctx.lineCap = 'round';
        ctx2.shadowBlur = 5;
        ctx2.shadowColor = 'rgb(0, 0, 0)';
        ctx2.moveTo(e.clientX, e.clientY);
    }

    el.onmouseup = function(e) {
        console.log(e.x);
        clicked = false;
        setInterval(function () {
            ctx2.clearRect(0, 0, el.width, el.height);
        }, 200)
    }


    el.onmousemove = function(e) {
        if (clicked == false) return;
        console.log(e.x);
        console.log(e.y);
        ctx2.lineTo(e.clientX, e.clientY);
        ctx2.stroke();
    }

    function drawPoint(ctx, x, y, r) {
        ctx.beginPath();
        ctx.arc(x, y, r, 0, 2 * Math.PI);
        ctx.fill();
    }

    function movePoint(trajectory, isLeft) {
        var trajRadius = isLeft ? trajectory.radius : -trajectory.radius;

        return {
            x: trajectory.x + trajRadius * Math.cos(trajectory.angle / 180 * Math.PI) / 1.2,
            y: canvas.height - (trajectory.y + trajectory.radius * Math.sin(trajectory.angle / 180 * Math.PI) * 2)
        };
    }

    var shouldRun = true;

    function frame() {
        ctx.clearRect(0, 0, canvas.width, canvas.height);

        angle++;

        if (angle == 180) {
            angle = 0;
        }
        var newPoint = movePoint({
            x: center.x + 100,
            y: center.y - 50,
            radius: radius,
            angle: angle
        });

        var newPoint2 = movePoint({
            x: center.x + 50,
            y: center.y,
            radius: radius,
            angle: angle
        }, true);

        drawPoint(ctx, newPoint.x, newPoint.y, point.radius);
        drawPoint(ctx, newPoint2.x, newPoint2.y, point.radius);

        window.requestAnimationFrame(frame);

    }

    frame();
};