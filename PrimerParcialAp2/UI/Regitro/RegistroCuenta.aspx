<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegistroCuenta.aspx.cs" Inherits="PrimerParcialAp2.UI.Regitro.RegistroCuenta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-header text-center col-6">

        <div class="page-header text-center col-8">
            <h1><strong>Registro De Cuentas</strong></h1>
            <br />

        </div>

        <div class="row">
            <div class="col-8">

                <div class="form-group row">
                    <label for="CuentaId" class="col-5 col-form-label text-right">Id:</label>
                    <asp:TextBox ID="CuentaIdTexBox" class="form-control justify-content-between col-3" runat="server"></asp:TextBox>


                </div>

                <div class="form-group row">
                    <label for="Fecha" class="col-5 col-form-label text-right">Fecha :</label>

                    <asp:TextBox class="form-control col-7" ID="FechaTextBox" placeholder="Fecha" runat="server" TextMode="Date"></asp:TextBox>
                </div>

                <div class="form-group row">
                    <label for="Balance" class="col-5 col-form-label text-right">Balance:</label>
                    <asp:TextBox ID="BalanceTextBox" class="form-control col-7" placeholder="Balance" runat="server"></asp:TextBox>
                </div>

                <div class="form-group row">
                    <label for="Nombre" class="col-5 col-form-label text-right">Nombre:</label>
                    <asp:TextBox ID="NombreTextBox" class="form-control col-7" placeholder="Nombre" runat="server"></asp:TextBox>
                </div>

                <div class="col-lg-12">
                    <div class="col-7 ml-md-auto">
                        <asp:Panel ID="AlertGuardar" Class="form-control alert-success text-center" runat="server" role="alert">
                            <asp:Label ID="MensajeGuardado" runat="server">!Se Guardo Con Exito! </asp:Label>
                        </asp:Panel>

                        <asp:Panel ID="AlertError" class="alert alert-danger text-center" role="alert" runat="server">
                            <asp:Label ID="MensajError" runat="server">¡Error!</asp:Label>
                        </asp:Panel>

                        <asp:Panel ID="AlerteExistencia" class="alert-success text-center" runat="server" role="alert">
                            <asp:Label ID="MensajeYa" runat="server">!Ya existe Esta cuenta! </asp:Label>
                        </asp:Panel>


                        <asp:Panel ID="Alert" class="alert-success text-center" runat="server" role="alert">
                            <asp:Label ID="MensajeLlenar" runat="server">! Favor Llenar Los Campos ! </asp:Label>
                        </asp:Panel>
                    </div>
                    <div class="col-lg-12">
                        <div class="col-10 ml-md-auto">
                            <asp:Button ID="BtnNuevo" runat="server" class="btn btn-primary" Text="Nuevo" OnClick="BtnNuevo_Click" />
                            <asp:Button ID="BtnEliminar" runat="server" class="btn btn-primary" Text="Eliminar" OnClick="BtnEliminar_Click" />
                            <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" class="btn btn-primary " OnClick="BtnGuardar_Click"/>
                        </div>
                    </div>


                </div>
            </div>
        </div>
    </div>
</asp:Content>
