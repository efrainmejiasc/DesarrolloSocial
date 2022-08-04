$(document).ready(function () {
    console.log("ready!");
    setTimeout(InicializarDataTable,1000);
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

function CantidadPersonas() {
    setTimeout(CantidadPersonasSum, 500);
}

function CantidadPersonasSum() {
    var cantidad1 = $("#cantidad1").val()  === '' ? 0: $("#cantidad1").val();
    var cantidad2 = $("#cantidad2").val() === '' ? 0 : $("#cantidad2").val();
    var cantidad3 = $("#cantidad3").val() === '' ? 0 : $("#cantidad3").val();
    var cantidad4 = $("#cantidad4").val() === '' ? 0 : $("#cantidad4").val();
    var cantidad5 = $("#cantidad5").val() === '' ? 0 : $("#cantidad5").val();
    var suma = parseInt(cantidad1) + parseInt(cantidad2) + parseInt(cantidad3) + parseInt(cantidad4) + parseInt(cantidad5);
    $("#tmiembros").val(suma);
}

function TotalIngreso() {
    setTimeout(TotalIngresoSum, 500);
}

   

function TotalIngresoSum() {
    var ingreso1 = $("#ingreso1").val() === '' ? 0 : $("#ingreso1").val();
    var ingreso2 = $("#ingreso2").val() === '' ? 0 : $("#ingreso2").val();
    var ingreso3 = $("#ingreso3").val() === '' ? 0 : $("#ingreso3").val();
    var ingreso4 = $("#ingreso4").val() === '' ? 0 : $("#ingreso4").val();
    var ingreso5 = $("#ingreso5").val() === '' ? 0 : $("#ingreso5").val();
    var suma = parseInt(ingreso1) + parseInt(ingreso2) + parseInt(ingreso3) + parseInt(ingreso4) + parseInt(ingreso5);
    $("#tingreso").val(suma);
}

function InicializarDataTable() {
 
    $('#cargaFamiliar').DataTable({
        language: {
            "url": "//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Spanish.json"
        },
        "bInfo": false,
        "lengthChange": false,
        pagingType: "simple"
    }); 
}
    
   

        
        
        
        
        
        
        
      

