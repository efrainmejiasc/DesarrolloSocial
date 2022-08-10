$(document).ready(function () {
    console.log("ready!");
    GetPaises();
});

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
        data: { id: id },
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

function ResgistroGestores() {

    var nombre = $('#nombre').val();
    var apellido = $('#apellido').val();
    var nacionalidad = $('#nacionalidad').val();
    var document = $('#document option:selected').text();
    var numeroDocument = $('#numeroDocument').val();
    var lugarNacimiento = $('#lugarNacimiento').val();
    var fechaNacimiento = $('fechaNacimiento').val();
    var edad = $('#edad').val();
    var nivelInstruccion = $('#nivelInstruccion option:selected').text();
    var pais = $('#pais').val();
    var estado = $('#estado').val();
    var ciudad = $('#ciudad').val();
    var municipioProvincia = $('#municipioProvincia').val();
    var codigo = $('codigo').val();
    var telefono = $('#telefono').val();
    var correo = $('#correo').val();
    var contraseña = $('#contraseña').val();
    var confirmarcontraseña = $('#confirmarcontraseña').val();

    //var confirmar = document.getElementById('confirmar').checked;

    if (nombre === '' || apellido === '' || nacionalidad === '' || document === '' || numeroDocument === '' ||
        lugarNacimiento === '' || fechaNacimiento === '' || edad === '' || nivelInstruccion === '' || pais === '' ||
        estado === '' || ciudad === '' || municipioProvincia === '' || codigo === '' || telefono === '' || correo === '' || contraseña === '' || confirmarcontraseña === '' || !confirmar)
    {
        toastr.warning("Todos los campos son requeridos");
        return false;
    }
    else if (!EmailValido(correo)) {
        toastr.warning("No es una direccion email valida");
        return false;
    }
    else if (contraseña !== confirmarContraseña) {
        toastr.warning("La contraseña debe ser igual");
        return false;
    }

    var gestores = {
        Nombres : nombre,
        Apellidos : apellido,
        Nacionalidad : nacionalidad,
        Documento : document,
        NumeroDocumento : numeroDocument,
        LugarNacimiento : lugarNacimiento,
        FechaNacimiento : fechaNacimiento,
        Edad : edad,
        NivelInstruccion : nivelInstruccion,
        Pais : pais,
        Estado : estado,
        Ciudad : ciudad,
        MunicipioProvincia : municipioProvincia,
        Telefono : codigo + " " + telefono,
        Correo : correo,
        Password : contraseña,
    };
   
    console.log(JSON.stringify(gestores));



    $.ajax({
        type: "POST",
        url: urlCrearRegistroGestor,
        data: { gestorModelStr: JSON.stringify(gestores) },
        datatype: "json",
        success: function (data) {
            console.log(data);
            if (data.estado) {
                toastr.success('Autorizado')
            }
            else
                toastr.warning("No autorizado");
        }
    });
    return false;

function EmailValido(mail) {
    const regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
        return regex.test(mail);
    }


}