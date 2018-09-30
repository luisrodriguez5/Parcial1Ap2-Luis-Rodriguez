<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Depositos.aspx.cs" Inherits="PrimerParcialAp2.UI.Regitro.Depositos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-header text-center col-6">

        <div class="page-header text-center col-8">
            <h1><strong>Registro De Depositos</strong></h1>
            <br />

        </div>

        <div class="row">
            <div class="col-8">

                <div class="form-group row">
                    <label for="DepositoId" class="col-5 col-form-label text-right">Id:</label>
                    <asp:textbox id="DepositoId" class="form-control justify-content-between col-3" runat="server"></asp:textbox>


                </div>

                <div class="form-group row">
                    <label for="Fecha" class="col-5 col-form-label text-right">Fecha :</label>

                    <asp:textbox class="form-control col-7" id="FechaTextBox" placeholder="Fecha" runat="server" textmode="Date"></asp:textbox>
                </div>

                <div class="form-group row">
                    <label for="CuentaDropDownList" class="col-5 col-form-label text-right">No.Cuenta</label>
                    <asp:dropdownlist id="DropDownList1" class="form-control col-7" runat="server"></asp:dropdownlist>
                </div>
                <div class="form-group row">
                    <label for="Concepto" class="col-5 col-form-label text-right">Concepto:</label>
                    <asp:textbox id="Concepto" class="form-control col-7" placeholder="Concepto" runat="server"></asp:textbox>
                </div>

                <div class="form-group row">
                    <label for="Monto" class="col-5 col-form-label text-right">Monto:</label>
                    <asp:textbox id="Monto" class="form-control col-7" placeholder="Monto" runat="server"></asp:textbox>
                </div>

                <div class="col-lg-12">
                    <div class="col-7 ml-md-auto">
                        <asp:panel id="AlertGuardar" class="form-control alert-success text-center" runat="server" role="alert">
                            <asp:Label ID="MensajeGuardado" runat="server">!Se Guardo Con Exito! </asp:Label>
                        </asp:panel>

                        <asp:panel id="AlertError" class="alert alert-danger text-center" role="alert" runat="server">
                            <asp:Label ID="MensajError" runat="server">¡Error!</asp:Label>
                        </asp:panel>

                        <asp:panel id="AlerteExistencia" class="alert-success text-center" runat="server" role="alert">
                            <asp:Label ID="MensajeYa" runat="server">!Ya existe Esta cuenta! </asp:Label>
                        </asp:panel>


                        <asp:panel id="Alert" class="alert-success text-center" runat="server" role="alert">
                            <asp:Label ID="MensajeLlenar" runat="server">! Favor Llenar Los Campos ! </asp:Label>
                        </asp:panel>
                    </div>
                    <div class="col-lg-12">
                        <div class="col-10 ml-md-auto">
                            <asp:button id="BtnNuevo" runat="server" class="btn btn-primary" text="Nuevo" />

                            <asp:button id="BtnGuardar" runat="server" text="Guardar" class="btn btn-primary " OnClick="BtnGuardar_Click" />
                        </div>
                    </div>


                </div>
            </div>
        </div>
    </div>
</asp:Content>
