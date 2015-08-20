/// <reference path="_reference.js" />
var canvasElement = document.getElementById("snake-canvas"),
    canvasRenderer = new Renderer.CanvasRenderer(canvasElement),
    game = new Games.SnakeGame(canvasRenderer);
    game.start();