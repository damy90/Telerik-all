define(function () {
    require.config({
        paths: {
            'jquery': 'node_modules/jquery/dist/jquery.min',
            'sammy': 'node_modules/sammy',
            'q': 'node_modules/q/q',
            //'http-requester': 'http-requester',
            //'validation-controller': 'validation-controller',
            //'ui': 'ui-controller',
            'controller': 'controller'
        }
    });

    require(['jquery', 'sammy', 'controller'], function ($, Sammy, Controller) {
        var appController = new Controller();
        appController.setEventHandler();

        var app = Sammy('#wrapper', function () {
            this.get("#/register", function () {
                appController.loadRegForm();
            });

            this.get("#/login", function () {
                appController.loadLoginForm();
            });
        });

        app.run('#/register');
    });
});