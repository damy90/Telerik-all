(function () {
    //check if running on Node.js
    if (typeof require !== 'undefined') {
        //load underscore if on Node.js
        _ = require('../Scripts/underscore.js');
    }

    var Book = Object.create({
        init: function (title, author) {
            this.title = title;
            this.author = author;
            return this;
        }
    });

    var books = [
        Object.create(Book).init('The Art Of Gangdam Style', 'Nikolay Kostov'),
        Object.create(Book).init('How to make a million buks', 'Nikolay Kostov'),
        Object.create(Book).init('How to "Google"', 'Nikolay Kostov'),
        Object.create(Book).init("Vuchkov's biggest fan, Aneliya Stoyanova", 'Aneliya Stoyanova'),
        Object.create(Book).init("Silence! I kil you", 'Achmed the dead terrorist'),
    ];

    var groupedByAuthors = _.groupBy(books, function (book) {
        return book.author;
    });

    var mostPopularAuthor = _.max(groupedByAuthors, function (item) {
        return item.length;
    })[0];

    console.log('The most popular author is: ' + mostPopularAuthor.author);
}());