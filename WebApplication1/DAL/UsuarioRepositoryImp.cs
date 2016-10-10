using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using System.Data;
using System.Configuration;


namespace WebApplication1.DAL
{
    public class UsuarioRepositoryImp : UsuarioRepository
    {
        private string conexionString = ConfigurationManager.ConnectionStrings["GESTLIBRERIAConnectionString"].ConnectionString;
        public Guid create(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void delete(Guid codigo)
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> getAll()
        {
            throw new NotImplementedException();
        }

        public Usuario update(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario getById(Guid codigo)
        {
            Usuario usuario = null;
            const string SQL = "mostrarUnUsuario";
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {

                SqlCommand command =  new SqlCommand (SQL, conexion);
                command.CommandText = SQL;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idUsuario", codigo);
                command.Connection = conexion;
                conexion.Open();
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) //si devuelve datos
                    {

                        while (reader.Read()) //cada vuelta que da sacando datos
                        {
                            usuario = parseUsuario(reader);
                        }
                    }
                }
            }
            return usuario;
        }

        private Usuario parseUsuario(SqlDataReader reader)
        {
            Usuario usuario = new Usuario();
            usuario.CodigoUsuario = new Guid(reader["idUsuario"].ToString());
            usuario.Nombre = reader["nombre"].ToString();
            usuario.Apellidos = reader["apellidos"].ToString();
            usuario.Email = reader["email"].ToString();
            usuario.Password = reader["password"].ToString();
            usuario.User = reader["usuario"].ToString();
            usuario.FNacimiento = Convert.ToDateTime(reader["fnacimiento"].ToString());


            return usuario;
        }
    }
}