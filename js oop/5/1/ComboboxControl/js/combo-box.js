define(['handlebars', 'jquery'], function (handlebars, $) {
	'use strict';

	$.fn.comboBox = function(options) {
	    var $comboBox = this;
	    $comboBox.html('');
	    $comboBox.addClass('combo-box');
	    var $currentItem = $('<div>').addClass('selected');
	    $comboBox.append($currentItem)
	    
		var itemsSource = options.data;
		var template = '{{#itemsSource}}' + options.template + '{{/itemsSource}}';
		var compiledTemplate = Handlebars.compile(template);
		
		var $comboBoxList = $('<div>').addClass('list');
		$comboBox.append($comboBoxList);
		$comboBoxList.html(compiledTemplate({
			itemsSource: itemsSource
		}));
		$comboBoxList.children().addClass('list-item');
		
		$comboBoxList.hide();
		var $selected = $comboBoxList.children().first().addClass('selected');
		$currentItem.html($selected.html())
		var isExapnded = false; 
		console.log($currentItem.outerHeight());
		$comboBoxList.height($(window).height() - $currentItem.height());

		$comboBox.on('click', function () {
			var $comboBoxList = $comboBox.find('.list');
		    if (isExapnded) {
		        $comboBoxList.hide();
		        $selected = $comboBoxList.find('.selected');
		        $currentItem.html($selected.html())
		        isExapnded = false;
		    } else {
		        $comboBoxList.show();
		        isExapnded = true;
		    }
		});

		$comboBoxList.on('click', '.list-item', function () {
		    var $clickedItem = $(this);
		    $comboBoxList.find('.selected').removeClass('selected');
		    $clickedItem.addClass('selected');
		    $currentItem.html($clickedItem.html())
		});
	}
});