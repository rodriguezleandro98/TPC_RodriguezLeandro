using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_RodriguezLeandro
{
    public partial class ListadodeAdm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AdmNegocio negocioadm = new AdmNegocio();
            dgvABM.DataSource = negocioadm.Listar();
            dgvABM.DataBind();
            InicializarDropDown();

        }
        private void InicializarDropDown()
        {
            AdmNegocio negocioadm = new AdmNegocio();
            FiltrarAdm.DataSource = negocioadm.Listar();
            FiltrarAdm.DataTextField = "Usuario";
            FiltrarAdm.DataValueField = "ID";
            FiltrarAdm.DataBind();
            FiltrarAdm.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }
    }
}