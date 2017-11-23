var __app = {

    ajax: function (params) {
        var paramsDefecto = {
            url: '/api/' + params.url,
            data: params.data ? params.data : null,
            type: params.type ? params.type : 'POST',
            dataType: 'json',
            success: function (respuesta) {
                __dom.ocultarCargador();
                __app.validarRespuestaAjax(respuesta, params.success);
            },
            error: function (err) {
                __dom.ocultarCargador();
                console.error(err);
            },
            beforeSend:__dom.mostrarCargador
        };
        $.ajax(paramsDefecto);
    },

    validarRespuestaAjax: function (respuesta, success) {
        switch (respuesta.Codigo) {
            case 0:
            case 1:
                success(respuesta);
                break;
            case -1:
                console.error(respuesta.Mensaje);
                __dom.mostrarError('Error en la petición', respuesta.Mensaje);
                break;
            case -2:
                //token invalido
                //redireccionar al login
                break;
        }
    },

    detenerEvento: function (e) {
        if (e.preventDefault) {
            e.preventDefault();
        }
        if (e.stopPropagation) {
            e.stopPropagation();
        }
        if (e.returnValue) {
            e.returnValue = false;
        }
    }



};