$(document).ready(function () {
    console.log("ready!");
    var date = FechaActual();
    $('#fechaRegistro').val(date);
    GetPaises();
});
function FechaActual() {

    var today = new Date();
    var year = today.getFullYear();
    var moth = (today.getMonth() + 1) <= 9 ? "0" + (today.getMonth() + 1) : (today.getMonth() + 1);
    var day = today.getDate() <= 9 ? "0" + today.getDate() : today.getDate();
    var date = year + '-' + moth + '-' + day;

    return date;
}
 

function GetPaises() {

    $.ajax({
        type: "GET",
        url: urlPaises,
        datatype: "json",
        success: function (content) {
            var indice = 0;
            $('#pais').empty();
            $('#pais').append('<option value="-1" disabled selected>Seleccione pais...</option>');
            $.each(content.data, function (index, item) {
                $('#pais').append("<option value=\"" + indice + "\">" + item.country + "</option>");
                indice++;
            });
        }
    });
    return false;
}


function GetCiudadesPais() {

    var id = $('#pais').val();

    $.ajax({
        type: "GET",
        url: urlCiudadesPais,
        data: {id: id},
        datatype: "json",
        success: function (content) {
            console.log(content);
            $('#estado').empty();
            $('#estado').append('<option value="-1" disabled selected>Seleccione estado...</option>');
            $.each(content, function (index, item) {
                $('#estado').append("<option value=\"" + item + "\">" + item + "</option>");
            });
        }
    });
    return false;
}

function EmailValido(mail) {
    const regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return regex.test(mail);
}


function CrearDatosPrincipalesRG() {
    var FechaRegistro = $('#fechaRegistro').val();
    var Pais = $('#pais').val();
    var Estado = $('#estado').val();
    var Ciudad = $('#ciudad').val();
    var Municipio= $('#municipio_provincia').val();
    var CodigoPostal = $('#codigoPostal').val();
    var ParroquiaDistrito = $('#parroquiaDist').val();
    var Urbanizacion = $('#urbanizacion').val();
    var Avenida = $('#avenida').val();
    var EdificioCasa = $('#edificioCasa').val();
    var Piso = $('#piso').val();
    var NumerodeApartamento = $('#apartamentoN').val();
    var PuntodeReferencia = $('#puntodeReferencia').val();
    var Codigo = $('#codigo').val();
    var Telefono = $('#telefono').val();
    var Codigo2 = $('#codigo').val();
    var TelefonoAlternativo = $('#telefonoAlternativo').val();
    var CorreoElectronico = $('#correo').val();


    if (FechaRegistro === '' || Pais === '' || Estado === '' || Ciudad === '' || Municipio === '' ||
        CodigoPostal === '' || ParroquiaDistrito === '' ||   Urbanizacion === '' || Avenida === '' || EdificioCasa === ''
        || Piso === '' || NumerodeApartamento === '' || PuntodeReferencia === '' || Codigo === '' || Telefono === '' || CorreoElectronico === '')
{ 

    toastr.warning("Todos los campos son requeridos");
      return false;
    }
    else if (!EmailValido(CorreoElectronico)) {
    toastr.warning("No es una direccion email valida");
    return false;
}


    var DatosPrincipalesRG= {
        FechaRegistro: FechaRegistro,
        Pais: Pais,
        Estado: Estado,
        Ciudad: Ciudad,
        Municipio: Municipio,
        CodigoPostal: CodigoPostal,
        Parroquia: ParroquiaDistrito,
        Urbanizacion: Urbanizacion,
        Avenida: Avenida,
        EdifioCasa: EdificioCasa,
        Piso: Piso,
        NumerodeApartamento: NumerodeApartamento,
        PuntodeReferencia: PuntodeReferencia,
        Telefono: Codigo + " " + Telefono,
        TelefonoAlternativo: Codigo2 + " " +  TelefonoAlternativo,
        CorreoElectronico: CorreoElectronico,
    };

$.ajax({
    type: "POST",
    url: urlCrearDatosPrincipalesRG,
    data: { DatosPrincipalesRG: JSON.stringify(DatosPrincipalesRG) },
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

function EmailValido(mail) {
    const regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return regex.test(mail);
}