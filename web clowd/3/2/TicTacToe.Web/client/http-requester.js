define(['jquery', 'q'], function ($, Q) {
    var HttpRequester = (function () {
        var makeHttpRequest = function (url, type, data, headers) {
            var deferred = Q.defer();
            headers = headers || {};
            headers["Access-Control-Allow-Origin"] = "*";

            $.ajax({
                url: url,
                type: type,
                data: data,
                dataType: "json",
                /*beforeSend: function (request) {
                    request.setRequestHeader("X-SessionKey", headers['X-SessionKey']);
                },*/
                headers: headers,
                //contentType: "application/json",
                //timeout: 5000,
                success: function (resultData) {
                    deferred.resolve(resultData);
                },
                error: function (errorData) {
                    deferred.reject(errorData);
                }
            });

            return deferred.promise;
        };

        //TODO: use makeHttpRequest directly
        var getJSON = function (url, data, headers) {
            return makeHttpRequest(url, "GET", data, headers);
        };

        var postJSON = function (url, data, headers) {
            return makeHttpRequest(url, "POST", data, headers);
        };

        var putJSON = function (url, data, headers) {
            return makeHttpRequest(url, "PUT", data, headers);
        };

        return {
            getJSON: getJSON,
            postJSON: postJSON,
            putJSON: putJSON
        };
    }());

    return HttpRequester;
});