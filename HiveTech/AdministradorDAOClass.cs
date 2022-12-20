using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HiveTech
{
    public class AdministradorDAO 
    {
        public MySqlConnection conexao { get; set; }

        public AdministradorDAO()
        {
            conexao = new MySqlConnection("Server=26.196.221.145;Database=HiveTechDB;Uid=sa;Pwd=123456;");
            conexao.Open();
        }

        internal void Alterar(Administrador administrador)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE administrador SET nome=@nome , email=e@email, senha=@senha, cpf=@cpf, data_de_nascimento=@data_de_nascimento, chave=@chave)";
            comando.Parameters.AddWithValue("@nome", administrador.Nome);
            comando.Parameters.AddWithValue("@email", administrador.Email);
            comando.Parameters.AddWithValue("@senha", administrador.Senha);
            comando.Parameters.AddWithValue("@cpf", administrador.Cpf);
            comando.Parameters.AddWithValue("@ data_de_nascimento", administrador.Data_Nascimento);
            comando.ExecuteNonQuery();
        }

        internal void Deletar(Administrador administrador) 
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"DELETE FROM administrador WHERE Id=@id";
            comando.Parameters.AddWithValue("@id", administrador.Id);
            comando.ExecuteNonQuery();
        }


        public bool VerifChave(string Chave) 
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM administrador where chaveDeAcesso = SHA2(@chave, 256)";
            comando.Parameters.AddWithValue("@chave", Chave);
            MySqlDataReader reader = comando.ExecuteReader();

            return reader.HasRows;
        }

        public bool IsAdmin(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM administrador where id = @id";
            comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = comando.ExecuteReader();

            return reader.HasRows;
        }

    }

}


