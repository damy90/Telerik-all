function solve(params) {
    /*var pcount = params[0] | 0,
        pobj = {};
    for (var i = 1; i <= pcount; i++) {
        var param = params[i].split('-');
        if (param[1] == "true")
            param[1] = true;
        else if (param[1] == "false")
            param[1] = false;
        else if (param[1].indexOf(';') != -1)
            param[1] = param[1].split(';');
        pobj[param[0]] = param[1];
    }

    var tcount = params[pcount] | 0;
    for (i = 0; i < tcount; i++) {
        var tline = params[i + pcount],
            prevar = tline.split('<nk-model>');
        if (prevar.length > 1) {
            var postvar = prevar[1].split('/<nk-model>');
            prevar = prevar[0];
            var thevar = postvar[0];
            postvar = postvar[1];
            var thevalue = pobj[thevar];
        }
    }*/



    var s = parseInt(params[0]);
    var result = '';

    var parameters = {};
    var paramName;
    var paramValue;

    params.forEach(function (row) {
        if (!row) {
            row = '';
        }
    });
    for (var i = 1; i <= s; i++) {
        paramName = params[i].split('-')[0];
        paramValue = params[i].split('-')[1];
        if (paramValue === 'true') {
            paramValue = true;
        } else if (paramValue === 'false') {
            paramValue = false;
        } else if (paramValue.indexOf(';') !== -1) {
            paramValue = paramValue.split(';');
        }
        parameters[paramName] = paramValue;
    }

    //console.log(parameters);
    params = params.slice(i);
    params = params.slice(1);
    var templateRows = parseInt(params[0]);
    result = params.join('\n');
    var regexModel = /<nk-model>\s*(.+?)\s*<\/nk-model>/g;
    result = result.replace(regexModel, function (match, paramName) {
        return parameters[paramName];
    });

    var findTemplateRegex = /<nk-template name="(\w+)">([\s\S]*?)<\/nk-template>/g;
    result = result.replace(findTemplateRegex, function (match, templateName, content) {
        regexRenderTemplate.match('<nk-template render="' + templateName + ' />');
        result = result.replace(regexRenderTemplate, content);
        return '';
    });
    //console.log(params);
    console.log(result.trim());
}

var test = ['6',
'title-Telerik Academy',
'showSubtitle-true',
'subTitle-Free training',
'showMarks-false',
'marks-3;4;5;6',
'students-Ivan;Gosho;Pesho',
'42',
'<nk-template name="menu">',
' <ul id="menu">',
' <li>Home</li>',
' <li>About us</li>',
' </ul>',
'</nk-template>',
'<nk-template name="footer">',
' <footer>',
' Copyright Telerik Academy 2014',
' </footer>',
'</nk-template>',
'<!DOCTYPE html>',
'<html>',
'<head>',
' <title>Telerik Academy</title>',
'</head>',
'<body>',
' <nk-template render="menu" />',
' <h1><nk-model>title</nk-model></h1>',
' <nk-if condition="showSubtitle">',
' <h2><nk-model>subTitle</nk-model></h2>',
' <div>{{<nk-model>subTitle</nk-model>}} ;)</div>',
' </nk-if>',
' <ul>',
' <nk-repeat for="student in students">',
' <li>',
' <nk-model>student</nk-model>',
' </li>',
' <li>Multiline <nk-model>title</nk-model></li>',
' </nk-repeat>',
' </ul>',
' <nk-if condition="showMarks">',
' <div>',
' <nk-model>marks</nk-model>',
' </div>',
'       </nk-if>',
' <nk-template render="footer" />',
'</body>',
'</html>'];

solve(test);