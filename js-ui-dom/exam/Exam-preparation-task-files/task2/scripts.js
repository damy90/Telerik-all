$.fn.tabs = function () {
    var $this = this;
    $this.addClass('tabs-container');
    var $tabItemContent = $('.tab-item-content');
    $tabItemContent.hide();
    var $tabs = $('.tab-item'); //$('#tab-item')
    var $startTab = $tabs.eq(0)
        .addClass('current');
    $startTab.find('.tab-item-content')
        .show();

    $tabs.on('click', function () {
        $tabItemContent.hide();
        $tabs.removeClass('current');
        var $this = $(this);
        $this.addClass('current')
            .find('.tab-item-content')
            .show();
    });
};