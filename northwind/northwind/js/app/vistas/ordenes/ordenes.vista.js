var ordenesVista = vista = {

    control : null,
    modelo : null,

    init: function () {
        control = ordenesControl;
        modelo = ordenesModelo;

        vista.configurarControles();
        control.cargarCategorias(vista.llenarComboCategorias);
    },

    llenarComboCategorias: function (respuesta) {
        console.log(respuesta);
        __dom.llenarCombo(respuesta.Datos);
    },

    configurarControles: function () {
        __dom.configurarCalendario(__dom.divForm.find('#txtFechaEnvio, #txtFechaRequerida'));
        __dom.divForm.find('#btnEnviar').on('click', vista.validarFormulario);
    },

    validarFormulario: function () {
        var requeridos = __dom.divForm.find('input[required]');
        var errores = 0;
        for (var i = 0; i < requeridos.length; i++) {
            var txt = $(requeridos[i]);
            if (txt.val().trim() === '') {
                txt.parent().addClass('has-error');
                errores++;
            } else {
                txt.parent().removeClass('has-error').addClass('has-success');
            }
        }

        if (errores > 0) {
            __dom.mostrarError('Formulario Incompleto', 'Debe diligenciar todos los campos obligatorios');
            __dom.divForm.find('div.has-error:first input').select();
        }
    },


};

ordenesVista.init();