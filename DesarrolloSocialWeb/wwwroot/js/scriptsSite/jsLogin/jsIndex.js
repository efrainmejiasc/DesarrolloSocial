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
    else if (!EmailValido(userMail)) {
        toastr.warning("No es una direccion email valida");
        return false;
    }

    $.ajax({
        type: "GET",
        url: urlLogin,
        data: { userMail: userMail, password: password },
        datatype: "json",
        success: function (data) {
            console.log(data);
            if (data.estado) {
                toastr.success(data.mensaje)
                setTimeout(RedirLogin, 2000);
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

function RedirLogin() {
    window.location.href = urlPrincipal;
}

