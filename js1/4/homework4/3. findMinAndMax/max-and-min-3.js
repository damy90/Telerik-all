function maxAndMin() {
	var input = document.getElementById('numbers').value,
		numbers = input.replace(/\s+/g, '').split(','),
		max = Number.MIN_VALUE,
		min = Number.MAX_VALUE,
		index,
		noValidInput = true;

	for (index in numbers) {
		if (!(isNaN(numbers[index] * 1) || (numbers[index] === ''))) {
			if ((numbers[index] * 1) > max) {
				max = numbers[index];
			}
			if (numbers[index] * 1 < min) {
				min = numbers[index];
			}
			noValidInput = false;
		}
	}

	if (!noValidInput) {
		jsConsole.writeLine('The smallest number was: ' + min);
		jsConsole.writeLine('The biggest number was: ' + max);
	} else {
		jsConsole.writeLine('There was no valid input');
	}
}