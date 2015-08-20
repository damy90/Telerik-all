define(['tech-store-models/item'], function (Item) {
	
	var Store;
	Store = (function () {
		function Store(name) {
			this._name = validateName(name);
			this._items = [];
		}
		
		Store.prototype.addItem = function(item){
			if(!(item instanceof Item)){
				throw {
					message: "This is not a store Item!"
				}
			}
		
			this._items.push(item);
			return this;
		}
		
		Store.prototype.getAll = function(){
			var result = this._items.slice(0);
			
			return sortItemsByName(this._items);
		}
		
		Store.prototype.getSmartPhones = function(){
			var result = this._items.filter(function(item){
				return (item.type === "smart-phone");
			});
			
			return sortItemsByName(result);
		}
		
		Store.prototype.getMobiles = function(){
			var result = this._items.filter(function(item){
				return (item.type === "smart-phone" || item.type === "tablet");
			});
			
			return sortItemsByName(result);
		}
		
		Store.prototype.getComputers = function(){
			var result = this._items.filter(function(item){
				return (item.type === "pc" || item.type === "notebook");
			});
			
			return sortItemsByName(result);
		}
		
		Store.prototype.filterItemsByPrice = function(range){
			var result;
			if(typeof range == "undefined"){
				var range = {};
			}
			
			range.min = range.min || 0;
			range.max = range.max || Infinity;
						
			result = this._items.filter(function(item){
				return (item.price > range.min && item.price < range.max);
			});
			
			
			return sortItemsByPrice(result);
		}
		
		Store.prototype.filterItemsByType = function(type){
			var result = this._items.filter(function(item){
				return (item.type === type);
			});
			
			return sortItemsByName(result);
		}
		
		Store.prototype.filterItemsByName = function(name){
			var result = this._items.filter(function(item){
				return (item.name.indexOf(name) > -1);
			});
			
			return sortItemsByName(result);
		}
		
		// Not sure how to implement this one
		Store.prototype.countItemsByType = function(){
			var result = [];
			var i;
			var len = this._items.length;
			var type;

			for(i = 0; i < len; i += 1){
				type = this._items[i].type;
				result[type]++;
			}
			
			return {
				result: result
			};
		}
		
		function sortItemsByName(items){
			items.sort(function(first, second){
				return first.name < second.name ? -1 : first.name > second.name ? 1 : 0;
			});
			
			return {
				items: items
			};
		}
		
		function sortItemsByPrice(items){
			items.sort(function(first, second){
				return first.price - second.price;
			});
			
			return {
				items: items
			};
		}
		
		function validateName(name){
			if(name.length < 6 || name.length > 40){
				throw {
					message: "Name should be between 6 and 40 characters long!"
				}
			}
			
			return name;
		}
		
		return Store;
	})();
	return Store;
});