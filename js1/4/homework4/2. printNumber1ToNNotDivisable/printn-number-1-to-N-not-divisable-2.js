function printNumber1ToNnotDivisable() {
	var number = jsConsole.readInteger("#number"),
		currentNum;

	if (number >= 1) {
		for (currentNum = 1; currentNum <= number; currentNum++) {
			if (currentNum % 3 !== 0 && currentNum % 7 !== 0) {
				jsConsole.writeLine(currentNum);
			}
		}

	} else if (number < 1) {
		for (currentNum = 1; currentNum >= number; currentNum--) {
			if (currentNum % 3 !== 0 && currentNum % 7 !== 0) {
				jsConsole.writeLine(currentNum);
			}
		}
	}
}