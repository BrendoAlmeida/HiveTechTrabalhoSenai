﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HiveTech
{
    class Administrador : Cliente
    {
        public int Id { get; set; }
        public string Chave { get; set; }
    }
        
}