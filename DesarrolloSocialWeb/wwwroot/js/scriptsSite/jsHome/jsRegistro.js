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

function GetExistenciaArticuloBodega_(id) {

    console.log(id);

    $.ajax({
        type: "GET",
        url: urlGetStockProductoBodega,
        data: { idArticulo: id },
        datatype: "json",
        success: function (data) {
 
            toastr.success("Exito");
            toastr.warning("Advertencia");
            toastr.error("Error");
        }
    });
    console.log(' ');
} 

function GetPaises() {

    $.ajax({
        type: "GET",
        url: 'https://restcountries.com/v3.0/all',
        datatype: "json",
        success: function (data) {
            console.log(data);
            $('pais').empty();
            $('#pais').append('<option value="-1" disabled selected>Seleccione pais...</option>');
            $.each(data, function (index, item) {
                $('#pais').append("<option value=\"" + item.name.common + "\">" + item.name.common + "</option>");
            });
        }
    });
    return false;
}

function EmailValido(mail) {
    const regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return regex.test(mail);
}