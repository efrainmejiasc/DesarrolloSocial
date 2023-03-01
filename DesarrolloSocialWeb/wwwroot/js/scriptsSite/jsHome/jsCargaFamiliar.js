$(document).ready(function () {
    console.log("ready!");
    //setTimeout(InicializarDataTable,1000);
    //CargaFamiliar();
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

//function InicializarDataTable() {
 
//    $('#cargaFamiliar').DataTable({
//        language: {
//            "url": "//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Spanish.json"
//        },
//        "bInfo": false,
//        "lengthChange": false,
//        pagingType: "simple"
//    }); 
//}
    
function RegistroCargaFamiliar() {

    var cantidad = $("#cantidad").val();
    var estudian = $("#estudian").val();
    var estudian = $("#estudian").val();




    $.ajax({
        type: "POST",
        url: urlRegistroCargaFamiliar,
        data: { CargaFamiliar: JSON.stringify(CargaFamiliar) },
        datatype: "json",
        success: function (data) {
            console.log(data);
            if (data.estado) {
                toastr.success(data.mensaje);
                setTimeout(RedirLogin, 2000);
            }
            else
                toastr.warning(data.mensaje);
        }
    });

    return false;
}  

//function GuardarFacturaDetalle() {
//    var empresa = $('#empresa').val();
//    var nombreEmpresa = $("#empresa option:selected").text();

//    var FacturaDetalleDTO = new Array();
//    var nfilas = $("#tablaLineas").find("tr");
//    var nFactura = $('#nFactura').val();
//    var pImpuesto = parseFloat($('#pImpuesto').val());
//    var pDescuento = parseFloat($('#pDescuento').val());

//    for (var i = 1; i < nfilas.length; i++) {
//        var celdas = $(nfilas[i]).find("td");
//        var x = {};
//        x.Linea = parseInt(i);
//        x.NumeroFactura = nFactura;
//        x.NombreArticulo = $(celdas[1]).text();
//        x.Descripcion = $(celdas[2]).text();
//        x.Cantidad = parseInt($(celdas[3]).text());
//        x.Unidad = $(celdas[4]).text();
//        x.PrecioUnitario = parseFloat($(celdas[5]).text());
//        x.Subtotal = parseFloat($(celdas[6]).text());
//        x.IdArticulo = 0;
//        x.PorcentajeImpuesto = pImpuesto;
//        x.Impuesto = 0;
//        x.PorcentajeDescuento = pDescuento;
//        x.Descuento = 0;
//        x.Total = parseFloat($(celdas[6]).text());
//        x.Fecha = FechaActual();
//        x.FechaModificacion = FechaActual();
//        x.IdUsuario = 0;
//        x.Activo = true;

//        FacturaDetalleDTO.push(x);
//    }

//    return false;
//}

function CargaFamiliar() {
    var CantidadDepersonasBajosuCargo = $('#cantidad').val();
    var NiñosEstudian = $('#niñosEstudian option:selected').text();
    var TienenDocumentoJefeDeFamilia =''
    var CantidadJefeDeFamilia = 0;
    var EstudiaJefeDeFamilia = ''
    var TrabajaJefeDeFamilia = ''
    var IngresoJefeDeFamilia = $('#ingreso1 option: selected').text();
    var ActividadCulturalJefeDeFamilia = ''
    var EmbarazosJefeDeFamilia = $('#embarazo1 option: selected').text();
    var EnfermedadDiscapacidadJefeDeFamilia = ''
    var TratamientoJefeDeFamilia = ''
    var TienenDocumentoNiños = $('#documentoNiños option: selected').text();
    var CantidadNiños = $('#documento2 option: selected').text();
    var EstudiaNiños = $('#estudia2 option: selected').text();
    var TrabajaNiños = $('#trabaja2 option: selected').text();
    var IngresoNiños = $('#ingreso2 option: selected').text();
    var ActividadCulturalNiños = $('#deporte2 option: selected').text();
    var EmbarazosNiños = $('#embarazo2 option: selected').text();
    var EnfermedadDiscapacidadNiños = $('#enfermedad2option: selected').text();
    var TratamientoNiños = $('#tratamiento2option: selected').text();
    var TienenDocumentoAdolecente = $('#documento3option: selected').text();
    var CantidadAdolecente = $('#documento3 option: selected').text();
    var EstudiaAdolecente = $('#estudia3 option: selected').text();
    var TrabajaAdolecente = $('#trabaja3 option: selected').text();
    var IngresoAdolecente = $('#ingreso3 option: selected').text();
    var ActividadCulturalAdolecente = $('#deporte3 option: selected').text();
    var EmbarazosAdolecente = $('#embarazo3 option: selected').text();
    var EnfermedadDiscapacidadAdolecente = $('#enfermedad3 option: selected').text();
    var TratamientoAdolecente = $('#tratamiento3 option: selected').text();
    var TienenDocumentoAdultos = $('#documento4 option: selected').text();
    var CantidadAdultos = $('#documento4 option: selected').text();
    var EstudiaAdultos = $('#estudia4 option: selected').text();
    var TrabajaAdultos = $('#trabaja4 option: selected').text();
    var IngresoAdultos = $('#ingreso4 option: selected').text();
    var ActividadCulturalAdultos = $('#deporte4 option: selected').text();
    var EmbarazosAdultos = $('#embarazo4 option: selected').text();
    var EnfermedadDiscapacidadAdultos = $('#enfermedad4 option: selected').text();
    var TratamientoAdultos = $('#tratamiento4 option: selected').text();
    var TienenDocumentoAdultosMayores = $('#documento5 option: selected').text();
    var CantidadAdultosMayores = $('#documento5 option: selected').text();
    var EstudiaAdultosMayores = $('#estudia5 option: selected').text();
    var TrabajaAdultosMayores = $('#trabaja5 option: selected').text();
    var IngresoAdultosMayores = $('#ingreso5 option: selected').text();
    var ActividadCulturalAdultosMayores = $('#deporte5 option: selected').text();
    var EmbarazosAdultosMayores = $('#embarazo5 option: selected').text();
    var EnfermedadDiscapacidadAdultosMayores = $('#enfermedad5 option: selected').text();
    var TratamientoAdultosMayores = $('#tratamiento5 option: selected').text();
    
  

    if (CantidadDepersonasBajosuCargo === '' || NiñosEstudian === '' || TienenDocumentoJefeDeFamilia === '' || CantidadJefeDeFamilia === '' || EstudiaJefeDeFamilia === '' || TrabajaJefeDeFamilia === '' || IngresoJefeDeFamilia === '' || ActividadCulturalJefeDeFamilia === '' || EnfermedadDiscapacidadJefeDeFamilia === '' || TratamientoJefeDeFamilia === ''
        || TienenDocumentoNiños === ''|| CantidadNiños === '' || EstudiaNiños === '' || TrabajaNiños === '' || IngresoNiños === '' || ActividadCulturalNiños === '' || EnfermedadDiscapacidadNiños === '' || TratamientoNiños === ''
        || TienenDocumentoAdolecente === '' || CantidadAdolecente === '' || EstudiaAdolecente === '' || TrabajaAdolecente === '' || IngresoAdolecente === '' || ActividadCulturalAdolecente === '' || EnfermedadDiscapacidadAdolecente === '' || TratamientoAdolecente === ''
        || TienenDocumentoAdultos === '' || CantidadAdultos === '' || EstudiaAdultos === '' || TrabajaAdultos === '' || IngresoAdultos === '' || ActividadCulturalAdultos === '' || EnfermedadDiscapacidadAdultos === '' || TratamientoAdultos === ''
        || TienenDocumentoAdultosMayores === '' || CantidadAdultosMayores === '' || EstudiaAdultosMayores === '' || TrabajaAdultosMayores === '' || IngresoAdultosMayores === '' || ActividadCulturalAdultosMayores === '' || EnfermedadDiscapacidadAdultosMayores === '' || TratamientoAdultosMayores === ''
    ) {  
     

    var CargaFamiliar = {
        CantidadDepersonasBajosuCargo: CantidadDepersonasBajosuCargo,
        NiñosEstudian: NiñosEstudian,
        TienenDocumentoJefeDeFamilia: TienenDocumentoJefeDeFamilia,
        CantidadJefeDeFamilia:CantidadJefeDeFamilia,
        EstudiaJefeDeFamilia: EstudiaJefeDeFamilia,
        TrabajaJefeDeFamilia: TrabajaJefeDeFamilia,
        IngresoJefeDeFamilia: IngresoJefeDeFamilia,
        ActividadCulturalJefeDeFamilia: ActividadCulturalJefeDeFamilia,
        EmbarazosJefeDeFamilia: EmbarazosJefeDeFamilia,
        EnfermedadDiscapacidadJefeDeFamilia: EnfermedadDiscapacidadJefeDeFamilia,
        TratamientoJefeDeFamilia: TratamientoJefeDeFamilia,
        TienenDocumentoNiños: TienenDocumentoNiños,
        CantidadNiños: CantidadNiños,
        EstudiaNiños: EstudiaNiños,
        TrabajaNiños: TrabajaNiños,
        IngresoNiños: IngresoNiños,
        ActividadCulturalNiños: ActividadCulturalNiños,
        EmbarazosNiños: EmbarazosNiños,
        EnfermedadDiscapacidadNiños: EnfermedadDiscapacidadNiños,
        TratamientoNiños: TratamientoNiños,
        TienenDocumentoAdolecente: TienenDocumentoAdolecente,
        CantidadAdolecente: CantidadAdolecente,
        EstudiaAdolecente: EstudiaAdolecente,
        TrabajaAdolecente: TrabajaAdolecente,
        IngresoAdolecente: IngresoAdolecente,
        ActividadCulturalAdolecente: ActividadCulturalAdolecente,
        EmbarazosAdolecente: EmbarazosAdolecente,
        EnfermedadDiscapacidadAdolecente: EnfermedadDiscapacidadAdolecente,
        TratamientoAdolecente: TratamientoAdolecente,
        TienenDocumentoAdultos: TienenDocumentoAdultos,
        CantidadAdultos: CantidadAdultos,
        EstudiaAdultos: EstudiaAdultos,
        TrabajaAdultos: TrabajaAdultos,
        IngresoAdultos: IngresoAdultos,
        ActividadCulturalAdultos: ActividadCulturalAdultos,
        EmbarazosAdultos: EmbarazosAdultos,
        EnfermedadDiscapacidadAdultos: EnfermedadDiscapacidadAdultos,
        TratamientoAdultos: TratamientoAdultos,
        TienenDocumentoAdultosMayores: TienenDocumentoAdultosMayores,
        CantidadAdultosMayores: CantidadAdultosMayores,
        EstudiaAdultosMayores: EstudiaAdultosMayores,
        TrabajaAdultosMayores: TrabajaAdultosMayores,
        IngresoAdultosMayores: IngresoAdultosMayores,
        ActividadCulturalAdultosMayores: ActividadCulturalAdultosMayores,
        EmbarazosAdultosMayores: EmbarazosAdultosMayores,
        EnfermedadDiscapacidadAdultosMayores: EnfermedadDiscapacidadAdultosMayores,
        TratamientoAdultosMayores: TratamientoAdultosMayores,
       
    }
 

   

    $.ajax({
        type: "POST",
        url: urlCrearCargaFamiliar,
        data: { CargaFamiliar: JSON.stringify(CargaFamiliar) },
        datatype: "json",
        success: function (data) {
            console.log(data);
            if (data.estado) {
                toastr.success(data.mensaje);
                //setTimeout(RedirLogin, 2000);
            }
            else
                toastr.warning(data.mensaje);
        }
    });

    return false;

    }
}
























































        
        
        
        
        
        
        
      

