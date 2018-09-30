using BLL;
using SistemaTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerParcialAp2.UI.Regitro
{
    public partial class Depositos : System.Web.UI.Page
    {
        private Entidades.Depositos depositos = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            AlertGuardar.Visible = false;
            AlerteExistencia.Visible = false;
            AlertError.Visible = false;
            Alert.Visible = false;
            //Alert.Visible = false;
            MensajeYa.Visible = false;

        }

        private void Limpiar()
        {
            depositos = null;
            DepositoId.Text = "";
            Monto.Text = "";
            Concepto.Text = "";
            //CategoriaTextBox.Text = "";
            FechaTextBox.Text = "";

        }

        private void LlenarCuentas()
        {
            DropDownList1.DataSource = CuentasBLL.GetListAll();
            DropDownList1.DataValueField = "CuentaId";
            DropDownList1.DataTextField = "Nombre";
            DropDownList1.DataBind();
        }

        private void LlenarCamposInstancia()
        {
            int id = 0;
            if (DepositoId.Text != "")
            {
                id = Utilidades.TOINT(DepositoId.Text);
            }
            depositos = new Entidades.Depositos(id, DateTime.Parse(FechaTextBox.Text), DropDownList1.Text, Concepto.Text, Utilidades.TODECIMAL(Monto.Text));
        }

        private bool Validar()
        {
            bool interutor = true;
            if (string.IsNullOrWhiteSpace(Concepto.Text))
            {
                interutor = false;
            }
            if (string.IsNullOrWhiteSpace(FechaTextBox.Text))
            {
                interutor = false;
            }

            if (string.IsNullOrWhiteSpace(Monto.Text))
            {
                interutor = false;
            }

            return interutor;
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                LlenarCamposInstancia();
                if (DepositosBLL.Guardar(depositos))
                {
                    DepositoId.Text = depositos.DepositoId.ToString();
                    //MensajeGuardado.Text = "Gardo";
                    AlertGuardar.Visible = true;
                    //ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Usuario guardado con exito');", addScriptTags: true);
                    //UtilidadesWeb.MostrarToastr(this, "Guardado", "Usuario", "info");
                    Limpiar();




                }
                else
                {
                    AlertError.Visible = true;
                }



            }
            else
            {
                Alert.Visible = true;
            }

        }
    }
}