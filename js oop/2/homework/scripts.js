var canvasRender = function (canvasElementId) {
    var canvas = document.getElementById(canvasElementId);
    var ctx = canvas.getContext("2d");
    var drawLine = function drawLine(startX, startY, endX, endY) {
        ctx.beginPath();
        ctx.moveTo(startX, startY);
        ctx.lineTo(endX, endY);
        ctx.stroke();
    };
    var drawElipse = function drawElipse(centerX, centerY, radiusX, obj) {
        //optional parameters (radiusY, start angle, end angle)
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
    };

    var drawRect = function (x, y, width, height, strokeColor, lineWidth, fillColor) {
        ctx.beginPath();
        ctx.save();
        lineWidth = lineWidth || 1;
        strokeColor = strokeColor || 'black';
        ctx.lineWidth = lineWidth;
        ctx.strokeStyle = strokeColor;
        ctx.rect(x, y, width, height);
        if (fillColor) {
            ctx.fillStyle = fillColor;
            ctx.fill();
        }

        ctx.stroke();
        ctx.restore();
    };
    return {
        drawLine: drawLine,
        drawElipse: drawElipse,
        drawRect: drawRect
    };
};