var __dom = {


    mostrarError: function (titulo, mensaje) {
        swal({
            title: titulo,
            text: mensaje,
            type: "error",
            confirmButtonText: "Aceptar",
        });
    },

    mostrarAlertaOk:function(titulo, mensaje){
        swal({
            title: titulo,
            text: mensaje,
            type: "success",
            confirmButtonText: "Aceptar",
        });
    },

    mostrarCargador: function () {
        console.log('Mostrar Cargador');
    },

    ocultarCargador: function () {
        console.log('Ocultar Cargador');
    },


    llenarCombo: function (data) {
    },

    configurarCalendario: function (controles) {
        controles.datepicker({
            format: "dd/mm/yyyy",
            calendarWeeks: true,
            autoclose: true,
            todayHighlight: true
        });
    },



};