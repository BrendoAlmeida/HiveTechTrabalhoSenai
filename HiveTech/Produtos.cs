using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace HiveTech
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Imagem { get; set; }
        public int Quantidade { get; set; }

        public Produto(int id, string nome, decimal preco, string imagem)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Imagem = imagem;
        }
        
        public int getId()
        {
            return Id;
        }
    }
}
