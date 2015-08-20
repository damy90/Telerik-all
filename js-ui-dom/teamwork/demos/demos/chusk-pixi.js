window.onload = function () {

    var startTime = Date.now();

    // create an new instance of a pixi stage
    var stage = new PIXI.Stage(0xFFFFFF);

    // create a renderer instance.
    var renderer = PIXI.autoDetectRenderer(400, 300);

    var textures, chuck;

    // add the renderer view element to the DOM
    document.body.appendChild(renderer.view);

    var loader = new PIXI.AssetLoader(["chuck.json"]);
    loader.onComplete = function () {
        // create a texture from an image path
        textures = [
            PIXI.Texture.fromImage("walk-0.png"),
            PIXI.Texture.fromImage("walk-1.png"),
            PIXI.Texture.fromImage("walk-2.png"),
            PIXI.Texture.fromImage("walk-3.png")
        ];
        // create a new Sprite using the texture
        chuck = new PIXI.Sprite(textures[0]);


        // position
        chuck.position.x = 200;
        chuck.position.y = 150;

        stage.addChild(chuck);

        requestAnimFrame(drawFrame);
    };
    loader.load();

    function drawFrame() {
        //change the texture at fixed interwals
        var time = Date.now(),
            frame = Math.floor((time - startTime) / 250) % 4;

        chuck.setTexture(textures[frame]);

        document.onkeydown = function (e) {
            var keyCode = e ? (e.which ? e.which : e.keyCode) : event.keyCode;

            switch (keyCode) {
            case 37:
                chuck.position.x -= 5;
                chuck.scale.x = -1;
                pressedKey = 'left';
                break;
            case 38:
                pressedKey = 'up';
                break;
            case 39:
                chuck.scale.x = 1;
                chuck.position.x += 5;
                pressedKey = 'right';
                break;
            case 40:
                pressedKey = 'down';
                break;
            }
        };
        // render the stage   
        renderer.render(stage);

        //updated whenever possible
        requestAnimFrame(drawFrame);
    }
};