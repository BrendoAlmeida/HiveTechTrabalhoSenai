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
            conexao = new MySqlConnection("Server=localhost;Database=HiveTech;Uid=root;Pws=;");
            conexao.Open();
        }

        internal void Inserir(Administrador administrador)
        {
            if (this.Checar(administrador.Chave))
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = @"INSERT INTO admistritador (nome, email, senha, cpf, data_de_nascimento, chave) VALUES (@nome; @email, sha2( @senha,256 ), @cpf, @data_de_nascimento, @chave)";
                comando.Parameters.AddWithValue("@nome", administrador.Nome);
                comando.Parameters.AddWithValue("@email", administrador.Email);
                comando.Parameters.AddWithValue("@senha", administrador.Senha);
                comando.Parameters.AddWithValue("@cpf", administrador.Cpf);
                comando.Parameters.AddWithValue("@data_de_nascimento", administrador.Data_Nascimento);
                comando.Parameters.AddWithValue("@chave", administrador.Chave);
                comando.ExecuteNonQuery();
            }
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


        protected bool Checar(string Chave) 
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM administrador where Chave = @chave";
            comando.Parameters.AddWithValue("@chave", Chave);
            MySqlDataReader reader = comando.ExecuteReader();

            reader.Close();
            return reader.HasRows;
        }

        public bool IsAdmin(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM administrador where id = @id";
            comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = comando.ExecuteReader();

            reader.Close();
            return reader.HasRows;
        }

    }

}


