define(function(require) {
    var BACKGROUND_IMAGE_SRC = 'images/background.jpg';

    var SuperMario = require('scripts/Models/SuperMario.js');
    var startX = 200;
    var startY = 470;
    var superMario = null;
    var sprite = null;

    var canvasWidth = 0;
    var canvasHeight = 0;
    var movementStep = 20;

    // Constructor
    function GameEngine(stage, layer) {
        canvasWidth = stage.attrs.width;
        canvasHeight = stage.attrs.height;

        var paper = new Raphael(0, 0, canvasWidth, canvasHeight);
        paper.image(BACKGROUND_IMAGE_SRC, 0, 0, canvasWidth, canvasHeight);

        superMario = new SuperMario(startX, startY);
        sprite = superMario.getSprite();

        layer.add(sprite);
        stage.add(layer);

        onFrameIndexChange();

        window.addEventListener('keydown', onKeyDown);
    }

    function onFrameIndexChange() {
        var frameCount = 0;
        sprite.on('frameIndexChange', function(evt) {
            if (sprite.animation() === 'move' && ++frameCount > 7) {
                sprite.animation('idle');
                frameCount = 0;
            }

            if (sprite.animation() === 'shoot' && ++frameCount > 1) {
                sprite.animation('idle');
                frameCount = 0;
            }


            if (sprite.animation() === 'jump' && ++frameCount > 3) {
                sprite.animation('idle');
                frameCount = 0;
            }
        });
    }

    function moveLeft() {
        if (superMario.posX - (movementStep + 90) < 0) {
            return;
        }

        sprite.setX(superMario.posX -= movementStep);
        sprite.scaleX(-1);
        sprite.attrs.animation = "move";
    }

    function moveRight() {
        if (superMario.posX + (movementStep + 90) > canvasWidth) {
            return;
        }

        sprite.setX(superMario.posX += movementStep);
        sprite.scaleX(1);
        sprite.attrs.animation = "move";
    }

    function shoot() {
        sprite.attrs.animation = "shoot";
    }
    count = 80;

    function moveUp() {
        sprite.setY(superMario.posY -= 10);

        if (count++ % 101 == 100) {
            count = 80;
            moveDown();
            return;
        }

        requestAnimationFrame(moveUp);

    }

    function moveDown() {
        sprite.setY(superMario.posY += 10);

        if (count++ % 101 == 100) {
            count = 80;
            return;
        }

        requestAnimationFrame(moveDown);

    }

    function jump() {
        sprite.attrs.animation = "jump";

        moveUp();
    }



    function onKeyDown(e) {
        switch (e.keyCode) {
            case 37:
                moveLeft();
                break;
            case 38:
                jump();
                break;
            case 13:
                shoot();
                break;
            case 39:
                moveRight();
                break;
        }
    }

    GameEngine.prototype.startGame = function() {
        sprite.start();
    };

    return GameEngine;
});