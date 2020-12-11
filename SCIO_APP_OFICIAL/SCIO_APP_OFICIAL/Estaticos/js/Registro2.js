function MostrarAsesor() {
    var CurAsesor = document.getElementById("idSeleccion");
    var Estudiante = document.getElementById("idEstudiante");
    if (CurAsesor.style.display == "block") {
        CurAsesor.style.display = "none";
        Estudiante.style.display = "block";
    }
    else {
        CurAsesor.style.display = "block";
        Estudiante.style.display = "none";
    }
}

function MostrarEstudiante() {
    var CurAsesor = document.getElementById("idSeleccion");
    var Estudiante = document.getElementById("idEstudiante");
    if (Estudiante.style.display == "block") {
        Estudiante.style.display = "none";
        CurAsesor.style.display = "block";
    }
    else {
        Estudiante.style.display = "block";
        CurAsesor.style.display = "none";
    }
}