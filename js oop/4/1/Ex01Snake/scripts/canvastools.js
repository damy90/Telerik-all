var shapeDrawer = (function(){
    var ctx;

    function setContext(elementID){
        var div = document.getElementById(elementID);
        ctx = div.getContext('2d');
    };

    function Clear(){
        ctx.clearRect(0,0,ctx.canvas.width, ctx.canvas.height);
    };

    function Rect(X,Y,width,height){
        ctx.beginPath();
        ctx.rect(X,Y,width,height);
        ctx.stroke();
    };

    function Circle(X,Y,radius){
        ctx.beginPath();
        ctx.arc(X, Y, radius, 0, 2*Math.PI);
        ctx.stroke();
    };

    function Line(X1,Y1,X2,Y2){
        ctx.beginPath();
        ctx.moveTo(X1, Y1);
        ctx.lineTo(X2, Y2);
        ctx.stroke();
    };

    return{
        setContext: setContext,
        Clear: Clear,
        Rect: Rect,
        Circle: Circle,
        Line: Line
    };

}());
