﻿function openNav() {
  document.getElementById("mySidenav").style.width = "100%";
}

function closeNav() {
  document.getElementById("mySidenav").style.width = "0";
}



function InitBannerSliderJs(bannerSlider, controlsSlider) {
    var slider = tns({
        container: bannerSlider,
        items: 1,
        slideBy: 'page',
        autoplay: true,
        autoplayHoverPause: true,
        autoplayButtonOutput: false,
        controls: false,
        /*controlsContainer: controlsSlider,*/
        mouseDrag: true,
        navPosition: "bottom",
    });
}