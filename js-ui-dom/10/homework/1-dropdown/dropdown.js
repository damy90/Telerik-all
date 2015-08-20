$.fn.dropdown = function () {
    // Get the Raw Data from the original Select
    var $selectTag = this;
    $selectTag.hide();
    var options = $selectTag.children();

    // Generate new List
    // Default selected
    var $container = $('<div>').addClass('dropdown-list-container');
    var $ul = $('<ul>').addClass('dropdown-list-options');
    var $selected = $(':selected');
    var $selectionContainer = $('<li>')
        .text($selected[0].innerHTML)
        .addClass('dropdown-list-options')
        .attr('data-value', 0)
        .appendTo($ul);
    
    // Options
    for (var j = 0; j < options.length; j++) {
        var currOption = $('<li>')
            .text(options[j].innerHTML)
            .addClass('dropdown-list-options')
            .attr('data-value', options[j].value)
            .on('click', function () {
                var $target = $(this);
                $selectionContainer.text($target.text());
            })
            .appendTo($ul);
    }
    
    var $allOptions = $selectionContainer.siblings().hide();

    $selectionContainer.on('click', function () {
        $allOptions.slideToggle();
    });
    $ul.appendTo($container);
    $container.appendTo($('body'));
};