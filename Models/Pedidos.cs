using System;
using System.Collections.Generic;
using MySqlConnector;
using Microsoft.AspNetCore.Http;
namespace projeto_cineplay.Models
{
    public class Pedidos
    {
        public int id {get; set;}
        public string nome {get; set;}
        public string email {get; set;}
        public string comentario {get; set;}
        public string data {get; set;}

    }
}