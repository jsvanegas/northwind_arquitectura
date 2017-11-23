<%@ Page Title="" Language="C#" MasterPageFile="~/vistas/template/NorthwindTemplate.Master" AutoEventWireup="true" CodeBehind="prueba.aspx.cs" Inherits="northwind.vistas.ordenes.prueba" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="estilos" runat="server">
    <style>
        .botones-ocultos {
            display:none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="libs" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="region_editable" runat="server">

    <div class="col-md-12">
        <div class="col-md-6">
            <h2>División 1</h2>  
            <button class="btn btn-primary botones-ocultos" disabled="disabled">Mostrar Datos</button>
        </div>
        <div class="col-md-6">
            <h2>División 2</h2>  
            <button class="btn btn-primary botones-ocultos" disabled="disabled">Mostrar Datos</button>
        </div>
        <button class="btn btn-success" id="btnActivar">Activar</button>
    </div>

</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="scripts" runat="server">
    
    <script>

        $('#btnActivar').on('click', function (e) {
            __app.detenerEvento(e);
            $('.botones-ocultos')
                .removeClass('botones-ocultos')
                .removeAttr('disabled');
        });

    </script>

</asp:Content>
