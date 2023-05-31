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
                <p>¡Te invitamos a explorar nuestro catálogo de productos!</p>
            </div>


        </div>
    </div>

    <!-- Cards de muestra -->
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
    </div>


</asp:Content>
