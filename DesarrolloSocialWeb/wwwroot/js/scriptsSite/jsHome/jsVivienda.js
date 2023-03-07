$(document).ready(function () {
    console.log("ready!");
   
});

function RedirLogin() { window.location.href = urlSoloParaUsodelgestorylafundacion };

function Vivienda() {

    var TipodeVivienda = $('#vivienda option:selected').text();
    var CondiciondelaVivienda = $('#condicionVivienda option:select').text();
    var RequerimientodelaVivienda = $('#requerimientosVivienda option:select').text();
    var TEnenciadelaVivienda = $('#tenenciaVivienda opttion:selet').text();
    var Agua = document.getElementById('agua').checked;
    var tieneAgua = '';
    if (Agua) {
        tieneAgua = 'SI';
    } else {
        tieneAgua = 'NO';
    }
    var Electricidad = document.getElementById('Electricidad').checked;
    var tieneElectricidad = '';
    if (Electricidad) {
        tieneElectricidad = 'SI';
    } else {
        tieneElectricidad = 'NO';
    }

    var AguasServidas = document.getElementById('AguasServidas').checked;
    var tieneAguasServidas = '';
    if (AguasServidas) {
        tieneAguasServidas = 'SI';
    }
    else {
        tieneAguasServidas = 'NO';
    }

    var Telefoníafija = document.getElementById('Telefoníafija').checked;
    var tieneTelefoníafija = '';
    if (Telefoníafija) {
        tieneTelefoníafija = 'SI';
    }
    else {
        tieneTelefoníafija = 'NO';

    }

    var AseoUrbanoRecolectordeBasura = document.getElementById('AseoUrbanoRecolectordeBasura').checked;
    var tieneAseoUrbanoRecolectordeBasura = '';
    if (AseoUrbanoRecolectordeBasura) {
        tieneAseoUrbanoRecolectordeBasura = 'SI';
    } else {
        tieneAseoUrbanoRecolectordeBasura = 'NO';
    }
    

    if (TipodeVivienda === '' || CondiciondelaVivienda === '' || RequerimientodelaVivienda === '' || TEnenciadelaVivienda === '') {
        toaster.warning('Todos los campos son requeridos');
        return false;
    }

    var Vivienda = {
        TipodeVivienda: TipodeVivienda,
        CondiciondelaVivienda: CondiciondelaVivienda,
        RequerimientodelaVivienda: RequerimientodelaVivienda,
        TEnenciadelaVivienda: TEnenciadelaVivienda,
        Agua: Agua,
        Electricidad: Electricidad,
        AguasServidas: AguasServidas,
        Telefoníafija: Telefoníafija,
        AseoUrbanoRecolectordeBasura: AseoUrbanoRecolectordeBasura
    }
}