(function () {
    //check if running on Node.js
    if (typeof require !== 'undefined') {
        //load underscore if on Node.js
        _ = require('../Scripts/underscore.js');
    }

    var Student = Object.create({
        init: function (fname, lname, age, score) {
            this.fname = fname;
            this.lname = lname;
            this.age = age;
            this.fullname = fname + ' ' + lname;
            this.score = score;
            return this;
        },
        toString: function () {
            return this.fname + ' ' + this.lname;
        }
    });

    var students = [
        Object.create(Student).init('Doncho', 'Minkov', 18, 112),
        Object.create(Student).init('Nikolay', 'Kostov', 10, 30),
        Object.create(Student).init('Aneliya', 'Stoyanova', 24, 3),
        Object.create(Student).init('Ivaylo', 'Kenov', 26, 113),
        Object.create(Student).init('Todor', 'Stoyanov', 30, 60),
        Object.create(Student).init('Gosho', 'Stoyanov', 30, 60),
        Object.create(Student).init('Nikolay', 'Stoyanov', 30, 60)
     ];

    var filterStudents =
        _.filter(students, function (student) {
            return student.fname < student.lname;
        }).sort().reverse();

    console.log('---1. All students whose first name is before its last name alphabetically');
    _.each(filterStudents, function (student) {
        console.log(student.toString());
    });

    var filterStudentsByAge =
        _.filter(students, function (student) {
            return (student.age >= 18 && student.age <= 24);
        });

    console.log('---2. All students with age between 18 and 24');
    _.each(filterStudentsByAge, function (student) {
        console.log(student.toString());
    });

    var sortByMarks =
        _.sortBy(students, function (student) {
            return student.score;
        });

    console.log('---3. The student with highest marks:');
    console.log(_.last(sortByMarks).toString() + ': ' + _.last(sortByMarks).score);

    var groupFirstNames = _.groupBy(students, function (student) {
        return student.fname;
    });

    var groupLastNames = _.groupBy(students, function (student) {
        return student.lname;
    });

    var mostPopularFirstName = _.max(groupFirstNames, function (item) {
        return item.length;
    })[0];

    var mostPopularLastName = _.max(groupLastNames, function (item) {
        return item.length;
    })[0];
    console.log('---7. The most common first and last names are: ' + mostPopularFirstName.fname + ' and ' + mostPopularLastName.lname);

}());