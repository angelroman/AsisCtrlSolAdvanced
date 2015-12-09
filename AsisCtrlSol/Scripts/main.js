$(document).on('ready', function () {
    
    $("#btnLogin").on('click', function () {
        $("#mensaje").empty();
        var user = $("#inputUser").val();
        var pass = $("#inputPassword").val();
        $.ajax({
            beforeSend: function () {
                $('#mensaje').html("<i class='fa fa-spinner fa-spin fa-2x' style='display:inline; position:relative;'></i><p style='display:inline; position:relative'>Cargando...<p>");
            },
            dataType: 'json',
            type: 'POST',
            url: "/Auth/Login",
            data: { usr: user, pass: pass },
            error: function (jqXHR, estado, error) {
                console.log("estado: " + estado);
                console.log("error: " + error);
                $('#mensaje').html("<p style='display:inline; position:relative'>Lo sentimos, ha ocurrido algun error!<p>");
            },
            success: function (resp) {
                if (resp.Login === '1') { //Login correcto
                    $(window).attr('location', '/Home/Index')
                } else if (resp.Login === '0') {
                    $('#mensaje').html("<p style='display:inline; position:relative'>Error de usuario y/o contra&ntilde;a!<p>");
                } else {
                    $('#mensaje').html("<p style='display:inline; position:relative'>Lo sentimos, ha ocurrido algun error!<p>");
                }
            },
            complete: function (jqXHR, estado) {
                console.log("jqXHR: " + jqXHR);
                console.log("estado: " + estado);
            }
        }, 2000);
    });

});