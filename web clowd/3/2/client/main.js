define(function () {
    require.config({
        paths: {
            'jquery': 'node_modules/jquery/dist/jquery.min',
            'sammy': 'node_modules/sammy',
            'q': 'node_modules/q/q',
            'http-requester': 'http-requester',
            //'validation-controller': 'validation-controller',
            'ui': 'ui-controller',
            'controller': 'controller'
        }
    });

    require(['jquery', 'sammy', 'controller'], function ($, Sammy, Controller) {
        var appController = new Controller();
        appController.setEventHandler();
        //appController.createChatBox();

        var app = Sammy('#wrapper', function () {
            this.get("#/register", function () {
                appController.loadRegForm();
            });

            this.get("#/login", function () {
                appController.loadLoginForm();
            });

            this.get("#/chat", function () {
                appController.loadChatBox();
                if (appController.isLoggedIn()) {
                    $('#compose-post').show();
                } else {
                    $('#compose-post').hide();
                }
            });

            this.get("#/log-out", function () {
                appController.logOut();
                window.location = '#/login';
            });
        });

        app.run('#/login');
    });
});