using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datUser : Conexion
    {
        public bool Login(string user, string pass)
        {
            using(var connection = Conectar())
            {
                connection.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Usuario where user_usuario=@user and contrasena_usuario=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}
