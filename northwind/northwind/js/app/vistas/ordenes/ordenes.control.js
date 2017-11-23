var ordenesControl = {

    cargarCategorias: function (success) {
        __app.ajax({
            url: 'categorias/consultar',
            success:success
        });
    }
};