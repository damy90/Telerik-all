define(['todo-list/section'], function (Section) {
    'use strict';
    var Container;
    Container = (function () {
        function Container() {
            this._sections = [];
        }

        Container.prototype = {
            add: function (section) {
                if (!(section instanceof(Section))) {
                    throw new Error('not an section');
                }

                this._sections.push(section);
                return this;
            },
            getData: function () {
                //this._sections.getData();
                var map = Array.prototype.map;
                var result = map.call(this._sections, function (x) {
                    return x.getData();
                });

                return result;
            }
        };
        return Container;
    }());
    return Container;
});