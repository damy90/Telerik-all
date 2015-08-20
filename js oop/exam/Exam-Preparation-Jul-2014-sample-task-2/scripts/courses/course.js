define(['courses/student'], function (Student) {
    'use strict';
    var Course;
    Course = (function () {
        function Course(name, scoreFormula) {
            this.name = name;
            this.scoreFormula = scoreFormula;
            this._students = [];
        }

        /*function sortBy(st1, st2) {
			return st2.student[sortByParam] - st1.student[sortByParam];
		}*/

        Course.prototype = {
            getTopStudentsByExam: function (count) {
                var sorted = this._students.sort(createSortByNumberPropFunction('exam'));
                sorted = sorted.slice(0, count);
                return sorted;
            },

            getTopStudentsByTotalScore: function (count) {
                var sorted = this._students.sort(createSortByNumberPropFunction('totalScore'));
                sorted = sorted.slice(0, count);
                return sorted;
            },

            addStudent: function (student) {
                if (!(student instanceof(Student))) {
                    throw new Error('not a student');
                }

                this._students.push(student);
                return this;
            },

            calculateResults: function () {
                var map = Array.prototype.map;
                var that = this;
                this._students = map.call(this._students, function (student) {
                    student.totalScore = that.scoreFormula(student);
                    return student;
                });
            }
        };
        return Course;
    }());
    return Course;

    function createSortByNumberPropFunction(sortBy) {
        return function (st1, st2) {
            return st2[sortBy] - st1[sortBy];
        };
    }
});