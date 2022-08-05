$(document).ready(function () {
    console.log("ready!");
});

function Login() {

    var userMail = $('#userMail').val();
    var password = $('#password').val();
    var confirmar = document.getElementById('confirmar').checked;

    if (userMail === '' || password === '' || !confirmar) {
        toastr.warning("Todos los campos son requeridos");
        return false;
    }

    $.ajax({
        type: "GET",
        url: urlLogin,
        data: { userMail: userMail, password: password },
        datatype: "json",
        success: function (data) {
            if (data.estatus) {
                if (data.estatusFacturacion)
                    console.log('Exito')
            }
            else
                toastr.warning("No autorizado");
        }
    });
    return false;
}

