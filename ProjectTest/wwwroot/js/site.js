$(document).ready(function () {
    $('#bookCarousel').carousel({
        interval: 2000
    });



});






    var swiper = new Swiper('.swiper-container', {
        slidesPerView: 'auto', /* Exibe múltiplos itens ao mesmo tempo */
        spaceBetween: 15, /* Espaçamento entre os itens */
        freeMode: true, /* Permite rolar livremente os itens */
        loop: true, /* Habilita o loop */
        navigation: {
            nextEl: '.swiper-button-next', /* Setas de navegação */
            prevEl: '.swiper-button-prev',
        },
    });

document.title = "Açai Delight.ura";
