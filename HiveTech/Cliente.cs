﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HiveTech
{
    class Cliente
    {
        public int Id { get; set ; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public string Data_Nascimento { get; set; }

        public Cliente (string nome, string email, string senha, string cpf, string dt, int id = 0)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
            Data_Nascimento = dt;

        }
    }

}
