using System;
using System.Collections.Generic;
using MySqlConnector;
using Microsoft.AspNetCore.Http;
namespace projeto_cineplay.Models
{
    public class Usuarios
    {
        public int id {get; set;}
        public string nome {get; set;}
        public string email {get; set;}
        public string login {get; set;}
        public string senha {get; set;}
    
    }
}