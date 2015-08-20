$(function () {
    $('#before').on('click', function () {
        insertBefore($('h1'));
    });
    $('#after').on('click', function () {
        insertAfter($('h1'));
    });

    function insertBefore($sibling) {
        $('<div>').text('Inserted before original h1').insertBefore($sibling);
    }

    function insertAfter($sibling) {
        $('<div>').text('Inserted after original h1').insertAfter($sibling);
    }
});