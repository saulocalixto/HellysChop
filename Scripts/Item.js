$("#buttom-beer").click(function () {
    if ($("#beer").is(":visible")) {
        $("#beer").text("H$ 15 Hellys. Um Hellys Chopp para matar sua sede!").slideUp();
    } else {
        $("#beer").text("H$ 15 Hellys. Um Hellys Chopp para matar sua sede!").slideDown();
    }
});


$("#buttom-suco").click(function () {
    if ($("#suco").is(":visible")) {
        $("#suco").slideUp();
    } else {
        $("#suco").text("H$ 7 Hellys. Um Hellys Suco para matar sua sede!").slideDown();
    }
});

$("#buttom-burger").click(function () {
    if ($("#burger").is(":visible"))
    {
        $("#burger").slideUp();
    }
    else
    {
        $("#burger").text("H$ 12 Hellys.\n Um Hellys Hamburger para matar sua fome!").slideDown();
    }
    
});

$("#buttom-fritas").click(function () {
    if ($("#fritas").is(":visible"))
    {
        $("#fritas").text("H$ 10 Hellys. Uma Hellys Batata Frita para te matar!").slideUp();
    }
    else
    {
        $("#fritas").text("H$ 10 Hellys. Uma Hellys Batata Frita para te matar!").slideDown();
    }
    
});

$("#menuLink").click(function () {

    if ($(".wrapLink").is(":visible"))
    {
        $(".wrapLink").slideUp();
    }
    else
    {
        $(".wrapLink").slideDown();
    }
    
})


$(".esconder").click(function () {

    if($(".wrapDescricao").is(":visible"))
    {
        $(".wrapDescricao").slideUp();
        $(".esconder").text("Expandir");
    }
    else 
    {
        $(".wrapDescricao").slideDown();
        $(".esconder").text("Ocultar");
    }
})


