function test() {
    var domModule = (function () {
        var bufferElements = [];
        var MAX_BUFFER_SIZE = 10;

        this.appendChild = function appendChild(element, selector) {
            if (element && selector) {
                $(selector).append(element);
            }
        }

        function removeChild(parent, selector) {
            if (parent && selector) {
                $(parent).find(selector).remove();
            }
        }

        function addHandler(element, onEvent, eventFunction) {
            if (element && onEvent && eventFunction) {
                $(element).on(onEvent, eventFunction);
            }
        }

        function appendToBuffer(parentSelector, element) {
            if (!bufferElements[parentSelector]) {
                bufferElements[parentSelector] = [];
            }

            bufferElements[parentSelector].push(element);

            if (bufferElements[parentSelector].length === MAX_BUFFER_SIZE) {
                for (var i = 0; i < MAX_BUFFER_SIZE; i++) {
                    appendChild(bufferElements[parentSelector][i].cloneNode(true), parentSelector);
                }
                bufferElements[parentSelector] = [];
            }
        }

        return {
            //appendChild: appendChild,
            removeChild: removeChild,
            addHandler: addHandler,
            appendToBuffer: appendToBuffer
        };
    })();

    var div = document.createElement("div");
    var navItem = document.createElement("li");
    var button = document.createElement("a");
    button.innerHTML = 'Click me';
    button.className = 'button';
    div.innerHTML = 'div';
    navItem.innerHTML = 'added menu item';
    //appends div to #wrapper 
    domModule.appendChild(button, "#wrapper");
    domModule.appendChild(button.cloneNode(true), "#wrapper");
    //removes li:first-child from ul 
    domModule.removeChild("ul", "li:first-child");
    //add handler to each a element with class button 
    //$('body').append('a .button').html('Click me');
    domModule.addHandler("a.button", 'click', function () {
        alert("Clicked");
    });
    // if the buffering breaks two divs will be added every time
    domModule.appendToBuffer("#wrapper", div.cloneNode(true));
    for (var i = 0; i < 11; i++) {
        domModule.appendToBuffer("#main-nav ul", navItem);
    }
}