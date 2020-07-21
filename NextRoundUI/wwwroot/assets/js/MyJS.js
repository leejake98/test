function createAlert() {
    alert("Hello World");
}

function heroTyped() {
    // Hero typed
    if ($('.typed').length) {
        var typed_strings = $(".typed").data('typed-items');
        typed_strings = typed_strings.split(',')
        new Typed('.typed', {
            strings: typed_strings,
            loop: false,
            typeSpeed: 100,
            backSpeed: 50,
            backDelay: 2000,
            showCursor: false,
        });
    }

}

function runIsotope() {

    // Porfolio isotope and filter

    var portfolioIsotope = $('.portfolio-container').isotope({
        itemSelector: '.portfolio-item',
        getSortData: {
            RankingA: '.RankingA',
            RankingB: '.RankingB',
            RankingC: '.RankingC',
            RankingD: '.RankingD',
            RankingE: '.RankingE',
            DateTime: '.DateTime'
        },

        sortAscending: {
            RankingA: true,
            RankingB: true,
            RankingC: true,
            RankingD: true,
            RankingE: true,
            DateTime: false
        }

    });


    $('#portfolio-flters li').on('click', function () {
        $("#portfolio-flters li").removeClass('filter-active');
        $(this).addClass('filter-active');

        portfolioIsotope.isotope({
            filter: $(this).data('filter')
        });

    });

    $('#portfolio-sorts li').on('click', function () {


        portfolioIsotope.isotope({
            sortBy: $(this).data('filter')
        });

        //alert("Hello World " + $(this).data('filter'));
    });




}


function runCounterUp() {
    // jQuery counterUp
    $('[data-toggle="counter-up"]').counterUp({
        delay: 80,
        time: 1500
    });
}



function runCarousel() {
    // Portfolio details carousel
    $(".portfolio-details-carousel").owlCarousel({
        autoplay: true,
        dots: true,
        loop: false,
        items: 1,
        video: true,
        lazyLoad: true,
        center: true
    });
}

