define(['http-requester', 'ui'], function (HttpRequester, UI) { //, 'validation-controller'// ValidationController, 

    var Controller = (function () {
        var self = this;
        var serverUrl = 'http://jsapps.bgcoder.com/';
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

        Controller.prototype.loadChatBox = function () {
            var _this = this;

            $.when(
                $.get('templates/chat.html', function (data) {
                    $('#wrapper').html(data);
                    _this.updateChatBox();
                    setInterval(function () {
                        _this.updateChatBox();
                    }, _this.refreshTimeMS);

                    if (sessionStorage.getItem('sessionKey') != null) {
                        $('#compose-post').show();
                    } else {
                        $('#compose-post').hide();
                    }
                }));
        };

        Controller.prototype.isLoggedIn = function () {
            return self.getUsername() != null;
        };

        Controller.prototype.updateChatBox = function () {
            var _this = this;
            HttpRequester.getJSON(serverUrl + 'post')
                .then(function (data) {
                    var chatBoxHtml = UI.buildChatBox(data, _this.skipMessagesCount);
                    console.log(chatBoxHtml);
                    console.log('chatBoxHtml');
                    $('#chatbox').html(chatBoxHtml);
                });
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
                console.log(CryptoJS.SHA1(username + pass).toString());
                var authCode = CryptoJS.SHA1(username + pass).toString();
                HttpRequester.postJSON(serverUrl + 'auth', {
                    username: username,
                    authCode: authCode
                }).then(function (data) {
                    setLogin(data);
                }, function (error) {
                    console.log(error.responseText);
                });
            });

            $wrapper.on('click', '#post', function () {
                var inputTitle = $('#input-title').val(),
                    inputText = $("input-text").val(),
                    session = sessionStorage.getItem('sessionKey');
                HttpRequester.postJSON(serverUrl + 'post', {
                    title: inputTitle,
                    body: inputText
                }, {
                    'X-SessionKey': session
                }).then(function (data) {
                    setLogin(data);
                }, function (error) {
                    console.log(error.responseText);
                });
            });

            function setLogin(data) {
                sessionStorage.clear();
                console.log(_this.getUsername() + ': ' + _this.getSession());
                console.log(data.username);
                _this.setUsername(data.username);
                _this.setSession(data.sessionKey);
                console.log(_this.getUsername() + ': ' + _this.getSession());
                $('#user-info').text("Logged in as: " + data.username);

                $('#login-container').hide();
                $('#login').hide();
                $('#register').hide();
                $('#log-out').show();
            }

            $wrapper.on('click', '#register-button', function () {
                var registerUsername = $('#register-username-input').val();
                var registerPass = $('#register-password-input').val();
                var authCode = CryptoJS.SHA1(registerUsername + registerPass).toString();
                HttpRequester.postJSON(serverUrl + 'user', {
                    username: registerUsername,
                    authCode: authCode
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