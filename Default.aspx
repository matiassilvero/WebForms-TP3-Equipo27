<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForms_TP3_Equipo27.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Catálogo -->
    <div id="Catalogo">
        <div class="container" style="background-color: rgb(65, 65, 65);">
            <div class="text-light p-3 text-center" style="margin-top: 3rem;">
                <h4><strong>Catálogo</strong></h4>

                <p>¡Te invitamos a explorar nuestro catálogo de productos!</p>
            </div>

        </div>
    </div>

    <!-- Cards con repeater -->

 
        <div class="row row-cols-1 row-cols-md-3 g-4">
                <asp:Repeater runat="server" ID="repRepetidor">
            <ItemTemplate>

                <div class="col">
                    <div class="card" >
                        <img src=" <%#Eval("ImagenUrl")%>" class="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("Nombre") %> </h5>
                            <p class="card-text"><%#Eval("Descripcion") %> </p>
                          <p class="card-text">Codigo: <%#Eval("Codigo") %> ----- Precio: $<%#Eval("Precio") %> </p
                          <p class="card-text">Marca: <%#Eval("Marca") %> ----- Categoria: <%#Eval("Categoria") %> </p>
                           
                            <a href="DetalleArticulo.aspx?id=<%#Eval("ID") %>">Ver detalle</a>


                            <asp:button Text="Agregar a carrito" CssClass="btn btn-primary" ID="btnAgregar" 
                                runat="server" CommandArgument='<%#Eval("ID")%>' 
                                CommandName="ArticuloId" OnClick="btnAgregar_Click"/>
                        </div>
                    </div>
                </div>

            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
