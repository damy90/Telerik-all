window.onload = function () {

    var startTime = Date.now();
    var xpos = 0;

    // create an new instance of a pixi stage
    var canvas = document.getElementById("field");
    var stage = new PIXI.Stage(0xFFFFFF);

    // create a renderer instance.
    var renderer = PIXI.autoDetectRenderer(canvas.width, canvas.height, canvas, true);

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
        chuck.position.x = 70;
        chuck.position.y = 384;

        stage.addChild(chuck);

        requestAnimFrame(drawFrame);
    };
    loader.load();

    function drawFrame() {

        document.onkeydown = function (e) {
            var keyCode = e ? (e.which ? e.which : e.keyCode) : event.keyCode;

            switch (keyCode) {
            case 37:
                chuck.position.x -= 5;
                chuck.scale.x = -1;
                pressedKey = 'left';
                break;
            case 39:
                chuck.scale.x = 1;
                chuck.position.x += 5;
                pressedKey = 'right';
                break;
            }

            //if exiting canvas
            if (chuck.position.x > canvas.width - 50) {
                xpos += -canvas.width + 90;
                document.getElementById("level").setAttribute('patternTransform', "translate(" + xpos + ")");
                chuck.position.x = 50;
            }
            if (chuck.position.x < 50) {
                xpos += +canvas.width - 110;
                document.getElementById("level").setAttribute('patternTransform', "translate(" + xpos + ")");
                chuck.position.x = canvas.width - 50;
            }
        };
        //change the texture at fixed intervals
        var time = Date.now(),
            frame = Math.floor((time - startTime) / 150) % 4;

        chuck.setTexture(textures[frame]);

        renderer.render(stage);

        //updated whenever possible
        requestAnimFrame(drawFrame);
    }
};