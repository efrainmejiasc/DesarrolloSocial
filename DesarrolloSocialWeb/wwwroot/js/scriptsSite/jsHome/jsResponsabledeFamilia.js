$(document).ready(function () {
    console.log("ready!");

    var date = FechaActual();
    $('#fechaNacimiento').val(date);

});


function FechaActual() {

    var today = new Date();
    var year = today.getFullYear();
    var moth = (today.getMonth() + 1) <= 9 ? "0" + (today.getMonth() + 1) : (today.getMonth() + 1);
    var day = today.getDate() <= 9 ? "0" + today.getDate() : today.getDate();
    var date = year + '-' + moth + '-' + day;

    return date;

}

function MostrarDiscapacidad() {
    var discapacidad = $('#discapacidad').val();
    if (discapacidad == 1) {
        $('#lblTiposDiscapacidad').show();
        $('#tiposDiscapacidad').show();
    }
    else {
        $('#lblTiposDiscapacidad').hide();
        $('#tiposDiscapacidad').hide();
    }
        
}

