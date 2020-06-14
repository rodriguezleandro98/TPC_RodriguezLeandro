using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class AdmNegocio
    {
        public List<Adm> Listar()
        {
            List<Adm> lista = new List<Adm>();
            Adm administrador;
            AccesoaDatos datos = new AccesoaDatos();

            try
            {
                datos.SetearQuery("SELECT A.Estado, A.ID, A.NombreU, A.Contraseña, A.Nombres, A.Apellidos, A.IDTipodeusuario as IDTIPO, T.Nombre AS NOMBRETIPO FROM Adm as A inner join TipoUsuario as T ON T.ID = A.IDTipodeusuario");
                datos.EjecutarLector();

                while (datos.lector.Read())
                {
                    administrador = new Adm();
                    administrador.Estado = datos.lector.GetBoolean(0);
                    if (administrador.Estado)
                    {
                        administrador.Tipodeusuario = new Tipousuario();
                        administrador.Tipodeusuario.ID = datos.lector.GetInt32(6);
                        administrador.Tipodeusuario.Nombre = datos.lector["NOMBRETIPO"].ToString();
                        administrador.ID = datos.lector.GetInt32(1);
                        administrador.Usuario = datos.lector["NombreU"].ToString();
                        administrador.Contraseña = datos.lector["Contraseña"].ToString();
                        administrador.Nombres = datos.lector["Nombres"].ToString();
                        administrador.Apellidos = datos.lector["Apellidos"].ToString();
                       
                        lista.Add(administrador);
                    }

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
