document.addEventListener("DOMContentLoaded", function () {
    const carousel = document.querySelector(".product-carousel");
    const items = document.querySelectorAll(".product-card");
    const prevButton = document.querySelector(".left");
    const nextButton = document.querySelector(".right");

    if (!carousel || items.length === 0) return;

    let isMobile = window.innerWidth < 768;
    let isDragging = false;
    let startX, scrollLeft;

    function updateButtonsVisibility() {
        isMobile = window.innerWidth < 768;
        // Exibir as setas no mobile também, se necessário
        prevButton.style.display = isMobile ? "block" : "block"; // Ou "none" se quiser ocultar no mobile
        nextButton.style.display = isMobile ? "block" : "block"; // Ou "none" se quiser ocultar no mobile
    }

    function moveCarousel(direction) {
        const itemWidth = items[0].offsetWidth + 10; // Largura do item + gap
        carousel.scrollBy({ left: direction * itemWidth, behavior: "smooth" });
    }

    // Arrastar no mobile (touch)
    carousel.addEventListener("touchstart", (e) => {
        isDragging = true;
        startX = e.touches[0].pageX - carousel.offsetLeft;
        scrollLeft = carousel.scrollLeft;
    });

    carousel.addEventListener("touchmove", (e) => {
        if (!isDragging) return;
        const x = e.touches[0].pageX - carousel.offsetLeft;
        const walk = (x - startX) * 1.5; // Ajusta a sensibilidade
        carousel.scrollLeft = scrollLeft - walk;
    });

    carousel.addEventListener("touchend", () => {
        isDragging = false;
    });

    // Eventos de clique nos botões (PC)
    prevButton.addEventListener("click", () => moveCarousel(-1));
    nextButton.addEventListener("click", () => moveCarousel(1));

    // Atualizar visibilidade dos botões ao redimensionar a tela
    window.addEventListener("resize", updateButtonsVisibility);
    updateButtonsVisibility();
});
