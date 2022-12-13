using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HiveTech
{
    public class ClienteDAO
    {
        public MySqlConnection conexao { get; set; }

        public ClienteDAO()
        {
            conexao = new MySqlConnection("Server=localhost;Database=hivetechdb;Uid=root;Pwd=;");
            conexao.Open();
        }

        internal void Inserir(Cliente cliente)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO cliente (nome, email, senha, cpf, data_de_nascimento) VALUES (@nome, @email,sha2( @senha, 256), @cpf, @data_de_nascimento)";
            comando.Parameters.AddWithValue("@nome", cliente.Nome);
            comando.Parameters.AddWithValue("@email", cliente.Email);
            comando.Parameters.AddWithValue("@senha", cliente.Senha);
            comando.Parameters.AddWithValue("@cpf", cliente.Cpf);
            comando.Parameters.AddWithValue("@data_de_nascimento", DateTime.Parse(cliente.Data_Nascimento).ToString("yyyy-MM-dd"));
            comando.ExecuteNonQuery();
        }


        internal void Alterar(Cliente cliente)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE cliente SET nome = @Nome, email = @Email, senha = @Senha WHERE id = @ID";
            comando.Parameters.AddWithValue("@Nome", cliente.Nome);
            comando.Parameters.AddWithValue("@Email", cliente.Email);
            comando.Parameters.AddWithValue("@Senha", cliente.Senha);
            comando.ExecuteNonQuery();
        }

        internal void Apagar(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"DELETE FROM cliente WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();

        }
    }

}
