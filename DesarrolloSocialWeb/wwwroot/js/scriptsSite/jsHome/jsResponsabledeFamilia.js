﻿$(document).ready(function () {
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


function CrearDatosPrincipalesRG() {
    var Nombres = $('#nombre').val();
    var Apellidos = $('#apellido').val();
    var Nacionalidad = $('#nacionalidad option:selected').text();
    var Documento = $('#tipodocumento option:selected').text();
    var NumerodeDocumento = $('#numerodocument').val();
    var FechaNacimiento = $('#fechaNacimiento').val();
    var lugardeNacimiento = $('#lugarnacimiento').val();
    var Edad = $('#edad').val();
    var Sexo = $('#sexo option:selected').text();
    var EstadoCivil = $('#estadoCivil option:selected').text();
    var NiveldeInstruccion = $('#nivelInstruccion option:selected').text();
    var Profesion = $('#profesión').val();
    var Habilidades = $('#habilidades').val();
    var Trabaja = $('#trabaja option:selected').text();
    var CondicionLaboral = $('#condicionlaboral option:selected').text();
    var TipodeNegocio = $('#tipodenegocio option:selected').text();
    var MediodeTransporte = $('#profesión').val();
    var TieneHijos = $('#tienehijos option:selected').text();
    var NumerodeHijos = $('#cantidad').val();
    var TieneDiscapacidad = $('#discapacidad option:selected').text();
    var TipodeDiscapacidad = $('#tipodiscapacidad option:selected').text();
    var TieneTratamiento = $('#tratamiento option:selected').text();
    var PadeceEnfermedad = $('#padecedeenfermedad option:selected').text();
    var TipoEnfermedad = $('#tipoenfermedad option:selected').text();
    var Tienetratamiento = $('#tienetratamiento option:selected').text();
    var TipodeTratamiento = $('#tipotratamiento option:selected').text();
