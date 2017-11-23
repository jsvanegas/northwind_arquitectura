<%@ Page Title="" Language="C#" MasterPageFile="~/vistas/template/NorthwindTemplate.Master" AutoEventWireup="true" CodeBehind="ordenes.aspx.cs" Inherits="northwind.vistas.ordenes.ordenes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Órdenes de Compra
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="estilos" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="libs" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="region_editable" runat="server">
    <div class="col-md-12">
        <h1>Registro de órdenes de Compra</h1>
        <div class="row">
            <div class="form-group col-md-4">
                <label for="txtFechaEnvio">Fecha de Envío:</label>
                <input type="text" required="required" id="txtFechaEnvio" class="form-control" />
            </div>
            <div class="form-group col-md-4">
                <label for="txtFechaRequerida">Fecha Requerida:</label>
                <input type="text" required="required" id="txtFechaRequerida" class="form-control"  />
            </div>
            
            <div class="col-md-4">
                <button class="btn btn-primary" id="btnEnviar">Enviar</button>
            </div>

        </div>

        <div class="row">
            <div class="form-group col-md-4">
                <label for="cmbCategorias">Categorias:</label>
                <select id="cmbCategorias" class="form-control"></select>
            </div>
        </div>
    </div>
</asp:Content>


<asp:Content ID="Content5" ContentPlaceHolderID="scripts" runat="server">
    <script src="/js/app/vistas/ordenes/ordenes.modelo.js"></script>
    <script src="/js/app/vistas/ordenes/ordenes.control.js"></script>
    <script src="/js/app/vistas/ordenes/ordenes.vista.js"></script>
</asp:Content>
