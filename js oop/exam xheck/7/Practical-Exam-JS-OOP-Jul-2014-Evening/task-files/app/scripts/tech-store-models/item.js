define(function () {
	'use strict';
	var Item;
	Item = (function () {
		function Item(type, name, price) {
			this.type = validateType(type);
			this.name = validateName(name);
			this.price = price;
		}
		
		function validateType(type){
			if(type !== "accessory" || type !== "smart-phone" || type !== "notebook" ||
				type !== "pc" || type !== "tablet"){
					message: (type + " is not a valide item type!")
			}
			
			return type;
		}
		
		function validateName(name){
			if(name.length < 6 || name.length > 40){
				throw {
					message: "Name should be between 6 and 40 characters long!"
				}
			}
			
			return name;
		}
		return Item;
	})();
	return Item;
});