define(['http-requester'], function (HttpRequester, ValidationController, UI) {//, 'validation-controller', 'ui'
    var Controller = (function () {
        var Controller = function () {
            //this.resourseUrl = resourceUrl;
            this.refreshTimeMS = 4000;
            //this.showLastMessagesCount = 200;
        };

        Controller.prototype.getUsername = function () {
            return sessionStorage.getItem('nickname');
        };

        Controller.prototype.getSession = function () {
            return sessionStorage.getItem('sessionKey');
        };

        Controller.prototype.setUsername = function (nickname) {
            return sessionStorage.setItem('nickname', nickname);
        };

        Controller.prototype.setSession = function (sessionKey) {
            return sessionStorage.setItem('sessionKey', sessionKey);
        };

        Controller.prototype.endSession = function (sessionKey) {

            return sessionStorage.setItem('sessionKey', sessionKey);
        };

        Controller.prototype.loadRegForm = function () {
            $('#wrapper').load('templates/register.html');
        };

        Controller.prototype.loadLoginForm = function () {
            $('#wrapper').load('templates/login.html');
        };

        Controller.prototype.setEventHandler = function () {
            var _this = this,
                $wrapper = $('#wrapper');

            $wrapper.on('click', '#login-button', function () {
                var $loginInput = $('#login-username-input'),
                    username = $loginInput.val(),
                    pass = $('#login-username-input').val();
                    //isValidUsername = ValidationController.isUsernameCorrect(username);
                var authCode = '9aab5aedfa56b93dd9e035ff2ecd2215a148e3d5';
                    HttpRequester.postJSON('http://localhost:40643/api/user/login', {
                        username: username,
                        authCode: authCode
                    }).then(function (data) { setLogin(data) }, function (error) {
                        console.log(error.responseText);
                    })
            });

            function setLogin(data) {
                sessionStorage.clear();
                console.log(_this.getUsername() + ': ' + _this.getSession());
                console.log(data.nickname);
                _this.setUsername(data.nickname);
                _this.setSession(data.sessionKey);
                console.log(_this.getUsername() + ': ' + _this.getSession());
            }

            $wrapper.on('click', '#register-button', function () {
                var registerUsername = $('#register-username-input').val();
                var registerNickname = $('#register-nickname-input').val();
                var registerPass = $('#register-password-input').val();
                var authCode = '9aab5aedfa56b93dd9e035ff2ecd2215a148e3d5';
                    HttpRequester.postJSON('http://localhost:40643/api/user/register', {
                        username: registerUsername,
                        nickname: registerNickname,
                        authCode: authCode
                    }).then(function (data) { setLogin(data) }, function (error) {
                        console.log(error);
                    })
            });
        };

        return Controller;
    }());

    return Controller;
});