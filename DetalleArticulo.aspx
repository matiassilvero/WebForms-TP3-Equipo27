<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="WebForms_TP3_Equipo27.DetalleArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <style>
        h3, .Detalle {
            color: yellow;
        }
        .img{
            text-align:center;
        }
    </style>

    <h3>Detalle de tu articulo: </h3>

    






    <div class="Detalle">

        <div class="row">
            <div class="col-6 ">
                <div class="mb-3">
                    <label for="txtId" class="form-label">Id:</label>
                    <asp:TextBox runat="server" ID="txtId" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="txtNombre" class="form-label">Nombre:</label>
                    <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="txtDescripcion" class="form-label">Descripcion:</label>
                    <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="txtMarca" class="form-label">Marca:</label>
                    <asp:TextBox runat="server" ID="txtMarca" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="txtCategoria" class="form-label">Categoria:</label>
                    <asp:TextBox ID="txtCategoria" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="txtCodigo" class="form-label">Codigo:</label>
                    <asp:TextBox ID="txtCodigo" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="txtPrecio" class="form-label">Precio:</label>
                    <asp:TextBox runat="server" ID="txtPrecio" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" />
                    <a href="Default.aspx">Volver atras</a>
                </div>
            </div>

            <div class="col-6" >
                <div class="img">
                    <asp:Image ID="imgArticulo" Width="85%" runat="server" />
                </div>
            </div>
        </div>



    </div>

</asp:Content>
