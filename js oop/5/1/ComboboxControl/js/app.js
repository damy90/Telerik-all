(function() {
	'use strict';
	require.config({
		paths: {
			'jquery': 'libs/jquery-1.11.1.min',
			'handlebars': 'libs/handlebars-v1.3.0',
			// 'combo-box': 'combo-box',
		}
	});

	require(['jquery', 'combo-box'], function($) {
		var people = [{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},{
			id: 1,
			name: "Doncho Minkov",
			age: 18,
			avatarUrl: "images/minkov.jpg"
		}, {
			id: 2,
			name: "Georgi Georgiev",
			age: 19,
			avatarUrl: "images/joreto.jpg"
		},];

		var template = $("#person-template").html();

		var $container = $('#dropdown-list');
		$container.comboBox({
			data: people,
			template: template
		});
	});
}());