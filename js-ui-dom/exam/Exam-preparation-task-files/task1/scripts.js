function createCalendar(selector, events) {
    var container = document.querySelector(selector);
    var dayBox = document.createElement('div');
    var date = document.createElement('strong');
    var tasks = document.createElement('div');

    dayBox.style.display = 'inline-block';
    dayBox.style.width = '14%';
    dayBox.style.height = '100px';
    dayBox.style.border = '1px solid black';

    dayBox.appendChild(date);
    dayBox.appendChild(tasks);

    var daysOfWeek = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];
    var DAYS_IN_MONTH_COUNT = 30;

    var dates = [];
    for (var i = 0; i < DAYS_IN_MONTH_COUNT; i++) {
        dates.push({
            title: '',
            date: daysOfWeek[i % 7] + ' ' + (i + 1) + ' June ' + 2014,
            time: '&nbsp;',
            duration: ''
        });
    }

    for (i = 0; i < events.length; i++) {
        var dayNumber = events[i].date - 1;
        dates[dayNumber].title = events[i].title;
        dates[dayNumber].time = events[i].hour;
        dates[dayNumber].duration = events[i].duration;
    }

    for (i = 0; i < DAYS_IN_MONTH_COUNT; i++) {
        tasks.innerHTML = dates[i].time + ' ' + dates[i].title;
        date.innerHTML = dates[i].date;
        var clonedNode = dayBox.cloneNode(true);
        container.appendChild(clonedNode);
    }
}