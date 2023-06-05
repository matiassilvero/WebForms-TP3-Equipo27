<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForms_TP3_Equipo27.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Catálogo -->
    <div id="Catalogo">
        <div class="container" style="background-color: rgb(65, 65, 65);">
            <%--<img src="multimedia\top_perfil.jpg" alt="" height= 350 rem style="object-position: right;" >--%>

            <div class="text-light p-3 text-center" style="margin-top: 3rem;">
                <h4><strong>Catálogo</strong></h4>
                <p>¡Te invitamos a explorar nuestro catálogo completo de productos!</p>
            </div>
        </div>
    </div>

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

    <!-- muestra de articulos con foreach-->
<%--    <div class="row row-cols-1 row-cols-md-3 g-4">
    <% foreach (var articulo in ListaArticulo) { %>
        <div class="col">
            <div class="card">
                <img src="<%= articulo.ImagenUrl %>" class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title"><%= articulo.Nombre %></h5>
                    <p class="card-text"><%= articulo.Descripcion %></p>
                    <p class="card-text">Codigo: <%= articulo.Codigo %></p>
                    <p class="card-text">Precio: $<%= articulo.Precio %></p>
                    <p class="card-text">Marca: <%= articulo.Marca.Descripcion %></p>
                    <p class="card-text">Categoría: <%= articulo.Categoria.Descripcion %></p>
                    <a href="DetalleArticulo.aspx?id=<%= articulo.ID %>">Ver detalle</a>
                    <asp:Button Text="Articulo" CssClass="btn btn-primary" ID="Button1" 
                        runat="server" CommandArgument='<%= articulo.ID %>' 
                        CommandName="ArticuloId" OnClick="btnArticulo_Click" />
                </div>
            </div>
        </div>
    <% } %>
</div>--%>

    <!-- muestra con Cards articulos de la web-->
  <!--   Cards de muestra  
    <div id="Catálogo">
        <div class="container" id="container-Lenguajes" style="background-color: black;">
            <br>
            <div class="row mx-2 px-2 mx-md-5 px-md-5 justify-content-center">
                <div class="col-6 col-sm-6 col-lg-3 mr-3 mb-4">
                    <div class="card h-100">
                        <img class="card-img-top" src="multimedia/rocket.png" alt="Card image">
                        <div class="card-body h-100 d-flex flex-column">
                            <h4 class="card-title">Producto1</h4>
                            <p class="card-text"><strong>Producto2</strong></p>
                        </div>
                    </div>
                </div>
                <div class="col-6 col-sm-6 col-lg-3 mr-3 mb-4">
                    <div class="card h-100">
                        <img class="card-img-top" src="multimedia/rocket.png" alt="Card image">
                        <div class="card-body h-100 d-flex flex-column">
                            <h4 class="card-title">Producto2</h4>
                            <p class="card-text"><strong>Producto2</strong></p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row mx-2 px-2 mx-md-5 px-md-5 justify-content-center">
                <div class="col-6 col-sm-6 col-lg-3 mr-3 mb-4">
                    <div class="card h-100">
                        <img class="card-img-top" src="multimedia/rocket.png" alt="Card image">
                        <div class="card-body h-100 d-flex flex-column">
                            <h4 class="card-title">Producto1</h4>
                            <p class="card-text"><strong>Producto2</strong></p>
                        </div>
                    </div>
                </div>
                <div class="col-6 col-sm-6 col-lg-3 mr-3 mb-4">
                    <div class="card h-100">
                        <img class="card-img-top" src="multimedia/rocket.png" alt="Card image">
                        <div class="card-body h-100 d-flex flex-column">
                            <h4 class="card-title">Producto2</h4>
                            <p class="card-text"><strong>Producto2</strong></p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <br>
    </div>-->

</asp:Content>
