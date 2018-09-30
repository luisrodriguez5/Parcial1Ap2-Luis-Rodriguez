using Entidades;
using SistemaTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerParcialAp2.UI.Consulta
{
    public partial class ConsultaCuenta : System.Web.UI.Page
    {
        public static List<Cuentas> Lista { get; set; }
        public Cuentas cuentas { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Lista = new List<Cuentas>();
            cuentas = null;

            if (!Page.IsPostBack)
            {
                Lista = BLL.CuentasBLL.GetListAll();

            }

        }

        private void LlenarGriw()
        {
            ConsultaCuentas.DataSource = Lista;
            ConsultaCuentas.DataBind();
        }

        private void Filtrar()
        {
            if (FiltrarDropDownList.SelectedIndex == 0)
            {
                Lista = BLL.CuentasBLL.GetListAll();
            }
            else if (FiltrarDropDownList.SelectedIndex != 0)
            {
                if (FiltrarDropDownList.SelectedIndex == 2)
                {
                    Lista = BLL.CuentasBLL.GetList(p => p.Nombre == FiltrarTextBox.Text);
                }

                if (FiltrarDropDownList.SelectedIndex == 4)
                {
                    DateTime FechaDesde = Convert.ToDateTime(FechaDesdeTextBox.Text);
                    DateTime FechaHasta = Convert.ToDateTime(FechaHastaTextBox.Text);
                    Lista = BLL.CuentasBLL.GetList(p => p.Fecha >= FechaDesde.Date && p.Fecha <= FechaHasta.Date);
                }

                if (FiltrarDropDownList.SelectedIndex == 1)
                {
                    int id = Utilidades.TOINT(FiltrarTextBox.Text);
                    Lista = BLL.CuentasBLL.GetList(p => p.CuentaId == id);
                }
            }
            LlenarGriw();

        }
        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FiltrarTextBox.Text) && FiltrarDropDownList.SelectedIndex != 0 && FiltrarDropDownList.SelectedIndex != 4)
            {
                ConsultaCuentas.DataBind();
                //AsignarTextoAlertaInfo("Por favor digite el dato que desea filtrar.");
                ImprimirButton.Visible = false;
            }
            else if (FiltrarDropDownList.SelectedIndex == 4)
            {
                if (string.IsNullOrEmpty(FechaDesdeTextBox.Text) || string.IsNullOrEmpty(FechaHastaTextBox.Text))
                {
                    ConsultaCuentas.DataBind();
                    //AsignarTextoAlertaInfo("Por favor eliga el rango de fecha que desea filtrar.");
                    ImprimirButton.Visible = false;
                }
                else
                {
                    Filtrar();
                    // BotonImprimirVisibleSiHayListas();
                }
            }
            else
            {
                // ImprimirButton.Visible = false;
                Filtrar();
                //BotonImprimirVisibleSiHayListas();
            }

        }
    }
}