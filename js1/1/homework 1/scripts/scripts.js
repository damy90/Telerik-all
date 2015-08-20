document.write('1. Assign all the possible JavaScript literals to different variables.');
var integerNubber = 3;
var floatNumber = 2.6;
var string = 'So Long, and Thanks for All the Fish';
var array = [1, 2, 3];
var bool = true;
var object = { firstName: "John", lastName: "Doe", age: 50, eyeColor: "blue" };
var nullVar = null;
var undefinedVar;

//2. Create a string variable with quoted text in it. For example: 'How you doin'?', Joey said.
var string2ndTask = '"So Long, and Thanks for All the Fish"';
//check
document.write('check asigned values: ' + '<br/>');
document.write('integer number: ' + integerNubber + '<br/>');
document.write('decimal number: ' + floatNumber + '<br/>');
document.write('string: ' + string + '<br/>');
document.write('array: ' + array + '<br/>');
document.write('boolean: ' + bool + '<br/>');
document.write('object: ' + object + '<br/>');
document.write('object name property: ' + object.firstName + '<br/>');

document.write('string with quted text: ' + string2ndTask + '<br/>');

document.write('null variable: ' + nullVar + '<br/>');
document.write('undefined variable: ' + undefinedVar + '<br/>' + '<br/>');

document.write('3. Try typeof on all variables you created.');
document.write('Task 3:' + '<br/>')
document.write('integer number: ' + typeof (integerNubber) + '<br/>');
document.write('decimal number: ' + typeof (floatNumber) + '<br/>');
document.write('string: ' + typeof (string) + '<br/>');
document.write('array: ' + typeof (array) + '<br/>');
document.write('boolean: ' + typeof (bool) + '<br/>');
document.write('object: ' + typeof (object) + '<br/>');

document.write('string with quted text: ' + typeof (string2ndTask) + '<br/>' + '<br/>');

document.write('4. Create null, undefined variables and try typeof on them.');
document.write('Task 4:' + '<br/>');
document.write('null variable: ' + typeof (nullVar) + '<br/>');
document.write('undefined variable: ' + typeof (undefinedVar));
