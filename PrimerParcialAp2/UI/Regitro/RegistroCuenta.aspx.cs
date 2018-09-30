using BLL;
using Entidades;
using SistemaTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerParcialAp2.UI.Regitro
{
    public partial class RegistroCuenta : System.Web.UI.Page
    {
        private Cuentas cuentas = null;
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
            cuentas = null;
            CuentaIdTexBox.Text = "";
            NombreTextBox.Text = "";
            BalanceTextBox.Text = "";
            //CategoriaTextBox.Text = "";
            FechaTextBox.Text = "";

        }

        private void LlenarCamposInstancia()
        {
            int id = 0;
            if (CuentaIdTexBox.Text != "")
            {
                id = SistemaTech.Utilidades.TOINT(CuentaIdTexBox.Text);
            }
            cuentas = new Cuentas(id, DateTime.Parse(FechaTextBox.Text) , NombreTextBox.Text, Utilidades.TODECIMAL(BalanceTextBox.Text));
        }

        private bool Validar()
        {
            bool interutor = true;
            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                interutor = false;
            }
            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                interutor = false;
            }

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                interutor = false;
            }
            if (string.IsNullOrWhiteSpace(BalanceTextBox.Text))
            {
                interutor = false;
            }
            if (Utilidades.ToDateTime(FechaTextBox.Text) == new DateTime(1, 1, 1))
            {
                interutor = false;
            }
            return interutor;
        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {

        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                LlenarCamposInstancia();
                
                if (CuentasBLL.Guardar(cuentas))
                {
                    CuentaIdTexBox.Text = cuentas.CuentaId.ToString();
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