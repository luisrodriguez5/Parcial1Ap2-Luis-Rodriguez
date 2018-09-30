<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ConsultaCuenta.aspx.cs" Inherits="PrimerParcialAp2.UI.Consulta.ConsultaCuenta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class=" container page-header text-left">
        <h1>Consulta de Cuentas</h1>
    </div>

    <div class="col-xs-12 col-sm-4 d-inline-block">
        <asp:dropdownlist cssclass="form-control" id="FiltrarDropDownList" runat="server">
                <asp:ListItem>Todos</asp:ListItem>
                <asp:ListItem>ID</asp:ListItem>
                <asp:ListItem>Nombre</asp:ListItem>
                <asp:ListItem>Fecha</asp:ListItem>
                <asp:ListItem>Nuero de cuenta</asp:ListItem>
            </asp:dropdownlist>
    </div>

    <div class="col-xs-12 col-sm-7 d-inline-block">
        <div class="form-group">
            <asp:textbox cssclass="form-control col-6" id="FiltrarTextBox" runat="server" autocomplete="off"></asp:textbox>
        </div>
    </div>

    <div class="col">
        <div class="form-group">
            <asp:checkbox id="FiltrarFechaCheckBox" runat="server" />
            <label for="ContentPlaceHolder1_FiltrarFechaCheckBox">Fitrar por fecha</label>
        </div>
    </div>

    <asp:panel id="FechasPanel" runat="server">
            <div class="col-xs-12 col-sm-4 d-inline-block">
                <div class="form-group">
                    <label for="ContentPlaceHolder1_FechaDesdeTextBox">Desde</label>
                    <asp:TextBox type="date" CssClass="form-control col-6" ID="FechaDesdeTextBox" runat="server" autocomplete="off"></asp:TextBox>
                </div>
            </div>

            <div class="col-xs-12 col-sm-5 d-inline-block">
                <div class="form-group">
                    <label for="ContentPlaceHolder1_FechaHastaTextBox">Hasta</label>
                    <asp:TextBox type="date" CssClass="form-control col-6" ID="FechaHastaTextBox" runat="server" autocomplete="off"></asp:TextBox>
                </div>
            </div>
        </asp:panel>

    <div class="float-left container">
        <asp:button cssclass="btn btn-primary  d-flex justify-content-around " id="BuscarButton" runat="server" text="Buscar" OnClick="BuscarButton_Click" />
    </div>

    <div class="row container">
        <div class="col-12">
            <asp:gridview cssclass="table table-responsive table-hover" borderstyle="None" autogeneratecolumns="false" gridlines="Horizontal"
                id="ConsultaCuentas" datakeynames="CuentaId, Nombre" showfooter="true" runat="server">
                    <HeaderStyle CssClass="bg-danger" />
                    <Columns>
                        <asp:BoundField DataField="CuentaId" HeaderText="Cuenta Id" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Balance" HeaderText="Balance" />

                        <asp:BoundField DataField="Fecha" DataFormatString="{0:d}" HeaderText="Fecha " />
                        <asp:TemplateField></asp:TemplateField>
                    </Columns>
                    <FooterStyle CssClass="bg-light" />
                </asp:gridview>
            <div class="float-right">
                <asp:button cssclass="btn btn-success" id="ImprimirButton" runat="server" text="Imprimir" />
            </div>
        </div>
    </div>


</asp:Content>
