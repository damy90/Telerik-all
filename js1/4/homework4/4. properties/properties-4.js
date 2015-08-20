function findProperties() {
	var arr1 = [window, navigator, document],
		property,
		arr,
		name,
		index;

	for (index in arr1) {
		arr = [];
		console.log(arr1[index]);
		for (property in arr1[index]) {
			console.log(property);
			arr.push(property);
		}

		arr = arr.sort();
		name = arr1[index].toString();
		jsConsole.writeLine(name.substr(8, name.length - 9) + ':');
		jsConsole.writeLine('Min: ' + arr[0]);
		jsConsole.writeLine('Max: ' + arr[arr.length - 1]);
	}
}