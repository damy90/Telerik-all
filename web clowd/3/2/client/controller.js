define(['http-requester', 'ui'], function (HttpRequester, UI) { //, 'validation-controller'// ValidationController, 

    var Controller = (function () {
        var self = this;
        var serverUrl = 'http://localhost:33257/';
        var Controller = function () {
            //this.serverUrl = serverUrl;
            this.refreshTimeMS = 4000;
            this.skipMessagesCount = 200;
        };

        Controller.prototype.getUsername = function () {
            return sessionStorage.getItem('username');
        };

        Controller.prototype.getSession = function () {
            return sessionStorage.getItem('sessionKey');
        };

        Controller.prototype.setUsername = function (username) {
            return sessionStorage.setItem('username', username);
        };

        Controller.prototype.setSession = function (sessionKey) {
            return sessionStorage.setItem('sessionKey', sessionKey);
        };

        //token_type
        Controller.prototype.setTokenType = function (token_type) {
            return sessionStorage.setItem('token_type', token_type);
        };
        Controller.prototype.logOut = function () {
            HttpRequester.putJSON(serverUrl + 'user', true, {
                'X-SessionKey': sessionStorage.getItem('sessionKey')
            }).then(function () {}, function (error) {
                console.log(error.responseText);
            });

            $('#user-info').text("");
            $('#login-container').show();
            $('#login').show();
            $('#register').show();
            $('#log-out').hide();
            sessionStorage.removeItem('username');
            sessionStorage.removeItem('sessionKey');
            return sessionStorage;
        };

        Controller.prototype.isLoggedIn = function () {
            return self.getUsername() != null;
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
                    pass = $('#login-password-input').val();
                //if()
                //console.log(CryptoJS.SHA1(username + pass).toString());
                //var authCode = CryptoJS.SHA1(username + pass).toString();
                HttpRequester.postJSON(serverUrl + 'token', {
                    grant_type: 'password',
                    username: username,
                    Password: pass
                }).then(function (data) {
                    setLogin(data);
                }, function (error) {
                    console.log(error.responseText);
                });
            });

            function setLogin(data) {
                sessionStorage.clear();
                _this.setUsername(data.userName);
                _this.setSession(data.access_token);
                //_this.SetTokenType(data.token_type);
                //console.log(_this.getUsername() + ': ' + _this.getSession());
                console.log(_this.getUsername() + ': ' + _this.getSession());
                console.log(data.userName);
                $('#user-info').text("Logged in as: " + data.userName);

                $('#login-container').hide();
                $('#login').hide();
                $('#register').hide();
                $('#log-out').show();
            }

            $wrapper.on('click', '#register-button', function () {
                var registerUsername = $('#register-username-input').val();
                var registerPass = $('#register-password-input').val();
                var confirmPass = $('#register-confirm-password-input').val();
                //var authCode = CryptoJS.SHA1(registerUsername + registerPass).toString();
                HttpRequester.postJSON(serverUrl + 'api/account/register', {
                    Email: registerUsername,
                    Password: registerPass,
                    ConfirmPassword: confirmPass
                }).then(function (data) {
                    setLogin(data);
                }, function (error) {
                    console.log(error.responseText);
                });
            });
        };

        return Controller;
    }());

    return Controller;
});