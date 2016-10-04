using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class index : System.Web.UI.Page
    {
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            cargaDatos();

        }

        private void cargaDatos()
        {
            try
            {
                string cadena = ConfigurationManager.ConnectionStrings["GESTLIBRERIAConnectionString"].ConnectionString;
                string SQL = "SELECT * FORM usuario";
                SqlConnection conn = new SqlConnection(cadena);
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter dAdapter = new SqlDataAdapter(SQL, conn);

                dAdapter.Fill(ds);
                dt = ds.Tables[0];

                grdv_Usuarios.DataSource = dt;
                grdv_Usuarios.DataBind();
                conn.Close();
            }
            catch (SqlException ex)
            {
                System.Console.Error.Write(ex.Message);
            }
            
        }

        protected void grdv_Usuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //int codigo;
            string command = e.CommandName;
            switch (command)
            {
                case "editUsuario":
                    //hemos pulsado el boton de editar
                    break;
                case "borrarUsuario":
                    //hemos pulsado el boton de borrar
                    break;

            }
                
        }
    }
}