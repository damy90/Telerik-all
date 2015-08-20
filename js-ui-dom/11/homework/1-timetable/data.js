var lesson,
    postTemplateHTML,
    postTemplate;
lesson = [
    {
        title: "Course Introduction",
        firstDate: "Wed 18:00, 28-May-2014",
        secondDate: "Thu 14:00, 29-May-2014"
    },
    {
        title: "Document Object Model",
        firstDate: "Wed 18:00, 28-May-2014",
        secondDate: "Thu 14:00, 29-May-2014"
    },
    {
        title: "HTML5 Canvas",
        firstDate: "Thu 18:00, 29-May-2014",
        secondDate: "Fri 14:00, 30-May-2014"
    }
];

postTemplateHTML = document.getElementById('Timetable-template').innerHTML;

postTemplate = Handlebars.compile(postTemplateHTML);

document.getElementById('root').innerHTML = postTemplate(lesson);