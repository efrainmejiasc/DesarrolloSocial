$(document).ready(function () {
    console.log("ready!");
    CargaFamiliar();
});



function CargaFamiliar() {

    $('#rol').empty();
    $('#rol').append('<option value="-1" disabled selected>Numero integrantes</option>');
    $('#rol').append("<option value=\"" + 1 + "\">" + '1' + "</option>");
    $('#rol').append("<option value=\"" + 2 + "\">" + '2' + "</option>");
    $('#rol').append("<option value=\"" + 3 + "\">" + '3' + "</option>");

    return false;

}