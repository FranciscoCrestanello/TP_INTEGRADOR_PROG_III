using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using Negocio;


namespace Vistas
{
	public partial class Compras : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(Session["Usuario"] == null){
				Response.Redirect("LoginForm.aspx");
            }
            else
			{
				CargarFacturas();
			}

			 void CargarFacturas(){
				NegocioVenta factura = new NegocioVenta();
				String CodUsuario = Session["IdUsuario"].ToString();
				gvfacturas.DataSource = factura.GetComprasxCliente(CodUsuario);
				gvfacturas.DataBind();
			}

		}
	}
}