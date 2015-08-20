var options,
    postTemplateHTML,
    postTemplate;
options = [
    {
        value: 1,
        text: "One"
    },
    {
        value: 2,
        text: "Two"
    },
    {
        value: 3,
        text: "Three"
    }
];

postTemplateHTML = document.getElementById('Timetable-template').innerHTML;

postTemplate = Handlebars.compile(postTemplateHTML);

document.getElementById('root').innerHTML = postTemplate(options);