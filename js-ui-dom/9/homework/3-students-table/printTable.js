$(function () {
    function printTable() {
        var $table = $('table');
var $thead = $('thead').appendTo($table);
var $tr = $('tr').appendTo($thead);
$tr.append($('th').text('First name'));
$tr.append($('th').text('Last name'));
$tr.append($('th').text('Grade'));

var $tbody = $('tbody').appendTo($table);
for (var i in students) {
    var $row = $('tr');
    $row.append($('td').text(students[i].firstName));
    $row.append($('td').text(students[i].lastName));
    $row.append($('td').text(students[i].grade));

    $row.appendTo($tbody);
}
$table.appendTo('body');
    }

    printTable();
});