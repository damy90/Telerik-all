define(function () {
    var UI = (function () {
        var div = document.createElement('div'),
            span = document.createElement('span'),
            strong = document.createElement('strong'),
            h1 = document.createElement('h1'),
            date = document.createElement('span');
        date.className = 'date';
        div.className = 'msgln';
        div.appendChild(h1);
        div.appendChild(strong);
        div.appendChild(span);
        div.appendChild(date);

        function buildMessage(title, postText, postDate, postBy) {
            h1.innerHTML = title;

            strong.innerHTML = postBy.username + ": ";
            span.innerHTML = postText;
            date.innerHTML = postDate;
            return div.cloneNode(true);
        }

        function buildChatBox(data, skipMessagesCount) {
            var docFragment = document.createDocumentFragment();

            for (var i = data.length - 1; i > Math.max(data.length - skipMessagesCount, 0); i--) {
                var post = data[i],
                    postTitle = post.title,
                    postBy = post.user.trim(),
                    postText = post.body.trim(),
                    postDate = post.postDate;

                if (!postBy || !postText || !postTitle || !postDate) {
                    continue;
                }

                var postHtml = buildMessage(postTitle, postText, postDate, postBy);
                docFragment.appendChild(postHtml);
            }

            return docFragment;
        }

        return {
            buildMessage: buildMessage,
            buildChatBox: buildChatBox
        };
    }());

    return UI;
});