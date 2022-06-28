using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data; //precisa
using System.Data.SqlClient;//precisa

namespace ProjetoAcademia.DAL
{
    class AlunoDAL
    {
        //colocar em uso a classe que gerencia a conexão
        Conexao con = new Conexao();

        public void Cadastrar(BLL.AlunoBLL aluno)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO ALUNO 
            (NOME, CPF, RG, EMAIL, DATANASCIMENTO) 
            VALUES 
            (@NOME, @CPF, @RG, @EMAIL, @DATANASCIMENTO)";
            cmd.Parameters.AddWithValue("@NOME",    aluno.Nome);
            cmd.Parameters.AddWithValue("@CPF",     aluno.Cpf);
            cmd.Parameters.AddWithValue("@RG",      aluno.Rg);
            cmd.Parameters.AddWithValue("@EMAIL",   aluno.Email);
            cmd.Parameters.AddWithValue("@DATANASCIMENTO", aluno.Datanascimento);
            cmd.Connection = con.Conectar(); //abrindo a conexão
            cmd.ExecuteNonQuery(); //executar o comando
            con.Desconectar(); //fechar a conexão
        }

        public void Excluir(BLL.AlunoBLL aluno)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"DELETE FROM Aluno WHERE CODALUNO = @CODALUNO;";
            cmd.Parameters.AddWithValue("@CODALUNO", aluno.Codaluno);
            cmd.Connection = con.Conectar(); //abrindo a conexão
            cmd.ExecuteNonQuery(); //executar o comando
            con.Desconectar(); //fechar a conexão
        }

        public void Atualizar(BLL.AlunoBLL aluno)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE ALUNO SET 
                                            NOME            = @NOME, 
                                            CPF             = @CPF, 
                                            RG              = @RG, 
                                            EMAIL           = @EMAIL, 
                                            DATANASCIMENTO  = @DATANASCIMENTO
                                WHERE CODALUNO = @CODALUNO;";

            cmd.Parameters.AddWithValue("@CODALUNO", aluno.Codaluno);
            cmd.Parameters.AddWithValue("@NOME", aluno.Nome);
            cmd.Parameters.AddWithValue("@CPF", aluno.Cpf);
            cmd.Parameters.AddWithValue("@RG", aluno.Rg);
            cmd.Parameters.AddWithValue("@EMAIL", aluno.Email);
            cmd.Parameters.AddWithValue("@DATANASCIMENTO", aluno.Datanascimento);
            cmd.Connection = con.Conectar(); //abrindo a conexão
            cmd.ExecuteNonQuery(); //executar o comando
            con.Desconectar(); //fechar a conexão
        }

        public BLL.AlunoBLL Retornar (BLL.AlunoBLL aluno)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM ALUNO WHERE CODALUNO = @CODALUNO";
            cmd.Parameters.AddWithValue("@CODALUNO", aluno.Codaluno);
            cmd.Connection = con.Conectar();
            SqlDataReader drow = cmd.ExecuteReader();
            if (drow.Read())
            {
                aluno.Codaluno          = Convert.ToInt16(drow["CODALUNO"]);
                aluno.Nome              = drow["NOME"].ToString();
                aluno.Cpf               = drow["CPF"].ToString();
                aluno.Rg                = drow["RG"].ToString();
                aluno.Email             = drow["EMAIL"].ToString();
                aluno.Datanascimento    = Convert.ToDateTime(drow["DATANASCIMENTO"].ToString());
            }
            drow.Close();
            con.Desconectar();
            return aluno;
        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT * FROM ALUNO",con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();//fechar a conexão
            return dt;
        }

        public DataTable ConsultarPorNome(BLL.AlunoBLL aluno)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT * FROM ALUNO
            WHERE NOME LIKE @NOME", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@NOME", aluno.Nome + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();//fechar a conexão
            return dt;
        }



    }
}
