using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class SupervisorNegocio
    {
        public List<Supervisor> Listar()
        {
            List<Supervisor> lista = new List<Supervisor>();
            Supervisor supervisor;
            AccesoaDatos datos = new AccesoaDatos();

            try
            {
                datos.SetearQuery("SELECT S.Estado, S.ID, S.NombreU, S.Contraseña, S.Nombres, S.Apellidos, S.IDTipodeusuario as IDTIPO, T.Nombre AS NOMBRETIPO FROM Supervisor as S inner join TipoUsuario as T ON T.ID = S.IDTipodeusuario");
                datos.EjecutarLector();

                while (datos.lector.Read())
                {
                    supervisor = new Supervisor();
                    supervisor.Estado = datos.lector.GetBoolean(0);
                    if (supervisor.Estado)
                    {
                        supervisor.Tipodeusuario = new Tipousuario();
                        supervisor.Tipodeusuario.ID = datos.lector.GetInt32(6);
                        supervisor.Tipodeusuario.Nombre = datos.lector["NOMBRETIPO"].ToString();
                        supervisor.ID = datos.lector.GetInt32(1);
                        supervisor.Usuario = datos.lector["NombreU"].ToString();
                        supervisor.Contraseña = datos.lector["Contraseña"].ToString();
                        supervisor.Nombres = datos.lector["Nombres"].ToString();
                        supervisor.Apellidos = datos.lector["Apellidos"].ToString();

                        lista.Add(supervisor);
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
