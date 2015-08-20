$(function () {
    var currentSlide = 0;
    setSlideToCurrent();
    $('#prev-button').on('click', prevSlide);
    $('#next-button').on('click', nextSlide);

    function nextSlide() {
        currentSlide++;
        if (currentSlide === slides.length) {
            currentSlide = 0;
        }

        setSlideToCurrent();
    }

    function prevSlide() {
        currentSlide--;
        if (currentSlide < 0) {
            currentSlide = slides.length - 1;
        }

        setSlideToCurrent();
    }

    function setSlideToCurrent() {
        $('#current-slide').html(slides[currentSlide]);
    }

    setInterval(nextSlide, 5000);
});