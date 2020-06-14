using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class TipoUsuariosNegocio
    {
		public List<Tipousuario> Listar()
		{
			AccesoaDatos datos = new AccesoaDatos();
			List<Tipousuario> lista = new List<Tipousuario>();
			Tipousuario tipousuario;
			try
			{
				datos.SetearQuery("SELECT ID, Nombre FROM TipoUsuario");
				datos.EjecutarLector();

				while (datos.lector.Read())
				{
					tipousuario = new Tipousuario();
					tipousuario.ID = datos.lector.GetInt32(0);
					tipousuario.Nombre = datos.lector["Nombre"].ToString();
					lista.Add(tipousuario);
				}

				return lista;
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				datos.CerrarConexion();
			}
		}
	}
}
