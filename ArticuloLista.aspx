<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ArticuloLista.aspx.cs" Inherits="WebForms_TP3_Equipo27.ArticuloLista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        h1, .Busqueda {
            color: yellow;
        }
    </style>


    <h1>Lista de Articulos</h1>

    <div class="Busqueda">


    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <asp:Label Text="Filtrar" runat="server" />
                <asp:TextBox runat="server" ID="txtfiltro" CssClass="form-control" AutoPostBack="true"
                    OnTextChanged="filtro_TextChanged" />
            </div>
        </div>

        <div class="col-6" style="display: flex; flex-direction: column; justify-content: flex-end;">
            <div class="mb-3">
                <asp:CheckBox Text="Filtro Avanzado"
                    CssClass="" ID="chkAvanzado" runat="server"
                    AutoPostBack="true"
                    OnCheckedChanged="chkAvanzado_CheckedChanged" />
            </div>
        </div>

        <%if (chkAvanzado.Checked)
    
            {%>
        <div class="row">
            <div class="col-3">
                <div class="mb-3">
                    <asp:Label Text="Campo" ID="lblCampo" runat="server" />
                    <asp:DropDownList runat="server" AutoPostBack="true" CssClass="form-control"
                        ID="ddlCampo" OnSelectedIndexChanged="ddlCampo_SelectedIndexChanged">
                        <asp:ListItem Text="Nombre" color="yellow"/>
                        <asp:ListItem Text="Categoria" />
                        <asp:ListItem Text="Marca" />
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-3">
                <div class="mb-3">
                    <asp:Label Text="Criterio" runat="server" />
                    <asp:DropDownList runat="server" ID="ddlCriterio" CssClass="form-control"></asp:DropDownList>
                </div>
            </div>
            <div class="col-3">
                <div class="mb-3">
                    <asp:Label Text="Filtro" runat="server" />
                    <asp:TextBox runat="server" ID="txtFiltroAvanzado" CssClass="form-control" />
                </div>
            </div>
            <%--            <div class="col-3">
                <div class="mb-3">
                    <asp:Label Text="Estado" runat="server" />
                    <asp:DropDownList runat="server" ID="ddlEstado" CssClass="form-control">
                        <asp:ListItem Text="Todos" />
                        <asp:ListItem Text="Activo" />
                        <asp:ListItem Text="Inactivo" />
                    </asp:DropDownList>
                </div>
            </div>--%>
        </div>
        <div class="row">
            <div class="col-3">
                <div class="mb-3">
                    <asp:Button Text="Buscar" CssClass="btn btn-primary" ID="btnBuscar"
                        runat="server" OnClick="btnBuscar_Click" />
                </div>
            </div>
        </div>
        <%}%>
    </div>

        <asp:GridView ID="dgvArticulos" DataKeyNames="id"
        CssClass="table" runat="server" AutoGenerateColumns="false"
        OnSelectedIndexChanged="dgvArticulos_SelectedIndexChanged"
        OnPageIndexChanging="dgvArticulos_PageIndexChanging"
        AllowPaging="true" PageSize="5">
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Marca" DataField="Marca.Descripcion" />
            <asp:BoundField HeaderText="Categoria" DataField="Categoria.Descripcion" />
            <%--aca el DataField es diferente porque tengo en mi clase Articulo la propiedad Marca y Categoria(las cuales son otra clase) --%>
        </Columns>
    </asp:GridView>
    <a href="Default.aspx" class="btn btn-primary">Volver atras</a>
        </div>



</asp:Content>
