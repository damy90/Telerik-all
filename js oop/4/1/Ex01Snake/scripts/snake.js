var snake = (function(){
    //hidden function

    //Snake object definition
    var Snake = (function(){
        var Snake = function(){
            this._units = [(new Unit(5,5)), (new Unit(4,5)), (new Unit(3,5))]; //an array holding all the unit objects, where _units[0] is the lead
            this._backwards = ('left'); //the direction in which the snake cannot advance
            this._forwards = ('right');
        };

        Snake.prototype.advance = function(direction){
            //directions: left, right, up, down
            if(direction === this._backwards){
                console.log('Unable to move backwards');
                return;
            };

            var nextSquare = this._units[0].getXY();  //get the current location of the Head
            switch(direction){
                case 'left':
                    if(nextSquare.x === 0) {return};
                    nextSquare.x += -1;
                    this._backwards = 'right'; break;
                case 'right':
                    if(nextSquare.x === 9) {return};
                    nextSquare.x += 1;
                    this._backwards = 'left'; break;
                case 'up':
                    if(nextSquare.y === 0) {return};
                    nextSquare.y += -1;
                    this._backwards = 'down'; break;
                case 'down':
                    if(nextSquare.y === 9) {return};
                    nextSquare.y += +1;
                    this._backwards = 'up'; break;
                default: return;
            }

            for(var i = this._units.length-1; i > 0 ; i--){
                var newCoord = this._units[i-1].getXY();
                this._units[i].setXY(newCoord);
            };
            this._units[0].setXY(nextSquare);

            console.log(nextSquare);
        };

        Snake.prototype.unitsOnGrid = function(gridSize){
            var centerDist = gridSize/2;
            var unitList = [];
            for(var i = 0; i < this._units.length; i++){
                var coord = this._units[i].getXY();
                coord.x = (coord.x*gridSize) + centerDist;
                coord.y = (coord.y*gridSize) + centerDist;
                unitList.push(coord);
            }
            return unitList;
        };

        return Snake;
    }());

    //Unit object definition
    var Unit = (function(){
        var Unit = function(x,y){
            this._location = {x:x, y:y}; //an object holding xy coords
        };

        Unit.prototype.setXY = function(coordsObj){
            this._location.x = coordsObj.x;
            this._location.y = coordsObj.y;
        };

        Unit.prototype.getXY = function(){
            var x = this._location.x;
            var y = this._location.y;
            //clone the location object
            return {x:x, y:y};
        };

        return Unit;
    }());

    return{
        Snake: Snake,
        Unit: Unit
    }
}()); //the snake 'namespace' module