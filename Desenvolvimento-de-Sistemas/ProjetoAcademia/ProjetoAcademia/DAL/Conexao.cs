using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoAcademia.DAL
{
    internal class Conexao
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local);
                                                Initial Catalog=BDACADEMIA;
                                                Integrated Security=True");
        public SqlConnection Conectar()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }

        public void Desconectar()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

    }

}
