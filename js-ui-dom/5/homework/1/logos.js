window.onload = function () {
    //telerik
    var paper = Raphael(10, 10, 4000, 2000);

    var telerikLogo = paper.path('M10 70 L30 50 L70 90 L50 110 L30 90 L70 50 L90 70');
    telerikLogo.attr({
        'stroke-width': 10,
        stroke: '#5CE600'
    });

    paper.setStart();

    var telerik = paper.text(100, 90, 'Telerik');
    telerik.attr({
        'font-weight': 'bold',
        'font-size': 70,
    });

    var tradeMark = paper.text(300, 90, '®');
    tradeMark.attr({
        'font-size': 35,
        'font-weight': 'bold',
    });

    var subtext = paper.text(110, 130, 'Develop experiences');
    subtext.attr({
        'font-size': 25,
    });

    var set = paper.setFinish();
    set.attr({
        'font-family': 'Calibri,Arial',
        'text-anchor': 'start'
    });

    //YouTube
    var paperYoutube = Raphael(10, 200, 300, 100);

    var redRect = paperYoutube.rect(120, 0, 155, 80, 20);
    redRect.attr({
        fill: '#EC2828',
        stroke: 'none'
    });

    paperYoutube.setStart();

    var you = paperYoutube.text(10, 40, 'You');

    var tube = paperYoutube.text(130, 40, 'Tube');
    tube.attr({
        fill: 'white'
    });

    var set2 = paperYoutube.setFinish();
    set2.attr({
        'font-size': 70,
        'font-family': 'Arial Narrow',
        'font-weight': 'bold',
        'text-anchor': 'start'
    }).scale(1, 1.2);
};