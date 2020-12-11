function AbrirMenu() {
    var cuMenu = document.getElementById("img_menu");
    var cuMenu1 = document.getElementById("img_menu1");
    var Fases = document.getElementById("Fase");
    if (cuMenu.style.display == "block") {
        cuMenu.style.display = "none";
        cuMenu1.style.display = "block";
        Fases.style.display = "block";
    }
    else {
        cuMenu.style.display = "block";
        cuMenu1.style.display = "none";
        Fases.style.display = "none";
    }
}
