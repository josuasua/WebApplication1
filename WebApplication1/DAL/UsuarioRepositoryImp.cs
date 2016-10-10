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
            const string SQL = "";
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {

                SqlCommand command = conexion.CreateCommand();
                command.CommandText = SQL;
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexion;
                conexion.Open();
                ;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
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


            return usuario;
        }
    }
}