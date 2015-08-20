(function () {
    //check if running on Node.js
    if (typeof require !== 'undefined') {
        //load underscore if on Node.js
        _ = require('../Scripts/underscore.js');
    }

    var Animal = Object.create({
        init: function (fname, lname, legsCount) {
            this.name = fname;
            this.species = lname;
            this.legsCount = setLegsCount(legsCount); // WAT!?
            return this;
        },
        toString: function () {
            return this.name + ' - ' + this.species + ' ' + this.legsCount + ' legs';
        }
    });

    function setLegsCount(count) {
        var validCounts = [2, 4, 6, 8, 100];
        if (validCounts.indexOf(count) === -1) {
            throw new Error("Nope! :D");
        }
        return count;
    }

    var animals = [
      Object.create(Animal).init('Doncho', 'Dog', 2),
      Object.create(Animal).init('Nikolay', 'Dog', 6),
      Object.create(Animal).init('Aneliya', 'Caterpilar', 100),
      Object.create(Animal).init('Ivaylo', 'Cat', 8),
      Object.create(Animal).init('Todor', 'Cat', 8),
      //Object.create(Animal).init('Todor', 'Cat', 5) //invalid test
     ];


    var sortByLegsCount = _.sortBy(animals, function (animal) {
        return animal.legsCount;
    });

    var groupBySpecies =
        _.groupBy(sortByLegsCount, function (animal) {
            return animal.species;
        });
    console.log('---Animals, grouped by species and sorted them by number of legs');
    console.log(groupBySpecies);

    var legsTotal = 0;
    _.each(animals, function (animal) {
        legsTotal += animal.legsCount;
    });

    console.log('---And the total ammount of legs of all the mutant animals iiiss (dont ask why!) : ' + legsTotal);
}());