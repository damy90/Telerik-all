var canvas = document.getElementById('the-canvas');

var bicycleStartPoint = {
    x: 70,
    y: 400
};
drawBicycle(bicycleStartPoint);

var headStartPoint = {
    x: 120,
    y: 200
};
drawHead(headStartPoint);

var houseStartPoint = {
    x: 400,
    y: 150
};
drawHouse(houseStartPoint);


function drawBicycle(startPoint) {
    var ctxBicycle = canvas.getContext('2d'),
        x = startPoint.x,
        y = startPoint.y;

    ctxBicycle.fillStyle = "#90CAD7";
    ctxBicycle.strokeStyle = "#31798B";
    ctxBicycle.lineWidth = 4;
    //left wheel
    drawElipse(ctxBicycle, x, y, 50);

    //right wheel
    drawElipse(ctxBicycle, x + 200, y, 50);

    //pedals wheel
    ctxBicycle.fillStyle = 'transparent';
    ctxBicycle.lineWidth = 2;
    drawElipse(ctxBicycle, x + 100, y, 15);

    //pedals
    drawLine(ctxBicycle, x + 109, y + 10, x + 125, y + 30);
    drawLine(ctxBicycle, x + 91, y - 10, x + 77, y - 30);
    //frame
    //left triangle
    drawLine(ctxBicycle, x, y, x + 100, y);
    drawLine(ctxBicycle, x + 100, y, x + 60, y - 80);
    drawLine(ctxBicycle, x + 60, y - 80, x, y);

    //right triangle
    drawLine(ctxBicycle, x + 60, y - 80, x + 180, y - 80);
    drawLine(ctxBicycle, x + 180, y - 80, x + 100, y);

    //front wheel holder
    drawLine(ctxBicycle, x + 180, y - 80, x + 200, y);

    //handle-bar
    drawLine(ctxBicycle, x + 180, y - 80, x + 173, y - 108);
    drawLine(ctxBicycle, x + 173, y - 108, x + 133, y - 98);
    drawLine(ctxBicycle, x + 173, y - 108, x + 183, y - 148);

    //seat
    drawLine(ctxBicycle, x + 60, y - 80, x + 45, y - 110);
    drawLine(ctxBicycle, x + 20, y - 110, x + 70, y - 110);
}

function drawHead(startPoint) {
    var ctxHead = canvas.getContext('2d'),
        x = startPoint.x,
        y = startPoint.y;

    ctxHead.fillStyle = "rgb(142,200,213)";
    ctxHead.strokeStyle = "rgb(32,81,92)";
    ctxHead.lineWidth = 2;

    //the head
    drawElipse(ctxHead, x, y, 40);

    //left eye
    drawElipse(ctxHead, x - 25, y - 10, 10, {
        radiusY: 5,
    });
    drawElipse(ctxHead, x - 28, y - 10, 1, {
        radiusY: 2,
    });

    //right eye
    drawElipse(ctxHead, x + 10, y - 10, 10, {
        radiusY: 5,
    });
    drawElipse(ctxHead, x + 7, y - 10, 1, {
        radiusY: 2,
    });

    //the nose
    ctxHead.beginPath();
    ctxHead.moveTo(x - 7, y - 10);
    ctxHead.lineTo(x - 15, y + 10);
    ctxHead.lineTo(x - 2, y + 10);
    ctxHead.stroke();

    //the mouth
    ctxHead.save();
    ctxHead.rotate(Math.PI / 20);
    drawElipse(ctxHead, x + 25, y + 5, 13, {
        radiusY: 5,
    });
    ctxHead.restore();

    //the hat
    ctxHead.fillStyle = "rgb(57,102,147)";
    ctxHead.strokeStyle = "black";

    drawElipse(ctxHead, x, y - 35, 50, {
        radiusY: 10,
    });
    ctxHead.fillRect(x - 30, y - 100, 60, 57);
    ctxHead.strokeRect(x - 30, y - 100, 60, 57);
    drawElipse(ctxHead, x, y - 44, 30, {
        radiusY: 6,
        startAngle: 0,
        endAngle: Math.PI
    });
    drawElipse(ctxHead, x, y - 100, 30, {
        radiusY: 6,
    });
}

function drawHouse(startPoint) {
    var ctxHouse = canvas.getContext('2d'),
        x = startPoint.x,
        y = startPoint.y;

    ctxHouse.fillStyle = 'RGB(149,89,89)';
    ctxHouse.strokeStyle = 'black';
    ctxHouse.lineWidth = 3;

    // draw house
    ctxHouse.fillRect(x, y, 300, 250);
    ctxHouse.strokeRect(x, y, 300, 250);

    // draw roof
    ctxHouse.beginPath();
    ctxHouse.moveTo(x, y);
    ctxHouse.lineTo(x + 150, y - 130);
    ctxHouse.lineTo(x + 300, y);
    ctxHouse.fill();
    ctxHouse.stroke();

    // draw chimney
    ctxHouse.fillRect(x + 220, y - 110, 40, 80);
    drawElipse(ctxHouse, x + 240, y - 110, 20, {
        radiusY: 5,
    });
    drawLine(ctxHouse, x + 220, y - 110, x + 220, y - 20);
    drawLine(ctxHouse, x + 260, y - 110, x + 260, y - 20);

    // draw windows
    drawWindow({
        x: x + 30,
        y: y + 30
    });
    drawWindow({
        x: x + 165,
        y: y + 30
    });
    drawWindow({
        x: x + 165,
        y: y + 125
    });

    // draw door
    ctxHouse.fillStyle = 'transparent';
    drawElipse(ctxHouse, x + 82, y + 150, 40, {
        radiusY: 20,
        startAngle: Math.PI,
        endAngle: (2 * Math.PI)
    });
    ctxHouse.beginPath();
    ctxHouse.moveTo(x + 42, y + 150);
    ctxHouse.lineTo(x + 42, y + 250);
    ctxHouse.moveTo(x + 122, y + 150);
    ctxHouse.lineTo(x + 122, y + 250);
    ctxHouse.moveTo(x + 82, y + 130);
    ctxHouse.lineTo(x + 82, y + 250);
    ctxHouse.stroke();
    drawElipse(ctxHouse, x + 70, y + 210, 5);
    drawElipse(ctxHouse, x + 94, y + 210, 5);

    function drawWindow(startPoint) {
        var x = startPoint.x,
            y = startPoint.y;

        ctxHouse.fillStyle = 'black';

        ctxHouse.fillRect(x, y, 50, 30);
        ctxHouse.fillRect(x + 55, y, 50, 30);
        ctxHouse.fillRect(x, y + 35, 50, 30);
        ctxHouse.fillRect(x + 55, y + 35, 50, 30);
    }
}

function drawElipse(ctx, centerX, centerY, radiusX, obj) {
    obj = (obj || 0);
    var radiusY = (obj.radiusY || radiusX),
        startAngle = (obj.startAngle || 0),
        endAngle = (obj.endAngle || (2 * Math.PI));

    var axisRatio = radiusY / radiusX;

    ctx.save();
    ctx.scale(1, axisRatio);
    ctx.beginPath();
    ctx.arc(centerX, centerY / axisRatio, radiusX, startAngle, endAngle);
    ctx.restore();
    ctx.fill();

    ctx.stroke();
}

function drawLine(ctx, startX, startY, endX, endY) {
    ctx.beginPath();
    ctx.moveTo(startX, startY);
    ctx.lineTo(endX, endY);
    ctx.stroke();
}