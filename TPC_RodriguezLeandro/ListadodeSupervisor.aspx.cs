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
    public partial class ListadodeSupervisor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SupervisorNegocio negociosup = new SupervisorNegocio();
            dgvSupervisor.DataSource = negociosup.Listar();
            dgvSupervisor.DataBind();
        }
    }
}