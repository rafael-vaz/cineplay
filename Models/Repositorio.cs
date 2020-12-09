using System;
using System.Collections.Generic;
using MySqlConnector;
using Microsoft.AspNetCore.Http;
namespace projeto_cineplay.Models
{
    public class Repositorio
    {

    private const string enderecoConexao = "Database=cineplay; Datasource=localhost; Username=root";

    public void Inserir_Usuario(Usuarios user){

        MySqlConnection conexao = new MySqlConnection(enderecoConexao);

        conexao.Open();

        string sqlInserir = "INSERT INTO usuarios (nome, email, login, senha) VALUES (@nome, @email, @login, @senha)";

        MySqlCommand comando = new MySqlCommand(sqlInserir, conexao);

        comando.Parameters.AddWithValue("@nome", user.nome);
        comando.Parameters.AddWithValue("@email", user.email);
        comando.Parameters.AddWithValue("@login", user.login);
        comando.Parameters.AddWithValue("@senha", user.senha);

        comando.ExecuteNonQuery();

        conexao.Close();
    }

    public void Inserir_Pedidos(Pedidos pe){

        MySqlConnection conexao = new MySqlConnection(enderecoConexao);

        conexao.Open();

        string sqlInserir = "INSERT INTO pedidos (nome, email, comentario, data) VALUES (@nome, @email, @comentario, @data)";

        MySqlCommand comando = new MySqlCommand(sqlInserir, conexao);
        
        pe.data = DateTime.Now.ToString();
;         
        comando.Parameters.AddWithValue("@nome", pe.nome);
        comando.Parameters.AddWithValue("@email", pe.email);
        comando.Parameters.AddWithValue("@comentario", pe.comentario);
        comando.Parameters.AddWithValue("@data", pe.data);

        comando.ExecuteNonQuery();

        conexao.Close();
    }

    public List<Pedidos> Retorna_Pedidos(){
    
    MySqlConnection conexao = new MySqlConnection(enderecoConexao);

    conexao.Open();

    string sqlListar = "SELECT * FROM pedidos ORDER BY data";

    MySqlCommand comando = new MySqlCommand(sqlListar, conexao);

   MySqlDataReader dados = comando.ExecuteReader();

   Pedidos pedidos;

    List<Pedidos> lista = new List<Pedidos>();

   while(dados.Read()){

       pedidos = new Pedidos();
      
       if(!dados.IsDBNull(dados.GetOrdinal("nome")))
       pedidos.nome = dados.GetString("nome");

       if(!dados.IsDBNull(dados.GetOrdinal("email")))
       pedidos.email = dados.GetString("email");

       if(!dados.IsDBNull(dados.GetOrdinal("comentario")))
       pedidos.comentario = dados.GetString("comentario");

        if(!dados.IsDBNull(dados.GetOrdinal("data")))
       pedidos.data = dados.GetString("data");

       lista.Add(pedidos);
   
   }

   conexao.Close();
   
   return lista;

    }

    public Usuarios Login(Usuarios u){

    MySqlConnection conexao = new MySqlConnection(enderecoConexao);

    conexao.Open();

    string sqlLogin = "SELECT * FROM usuarios WHERE login = @login AND senha = @senha";
    
    MySqlCommand comando = new MySqlCommand(sqlLogin, conexao);

    comando.Parameters.AddWithValue("@login", u.login);
    comando.Parameters.AddWithValue("@senha", u.senha);

    MySqlDataReader dados = comando.ExecuteReader();

    Usuarios user = null;
    
    if(dados.Read()){
    
    user = new Usuarios();
    
    user.id = dados.GetInt32("id_usuarios");

    if(!dados.IsDBNull(dados.GetOrdinal("nome")))
    user.nome = dados.GetString("nome");

    if(!dados.IsDBNull(dados.GetOrdinal("email")))
    user.email = dados.GetString("email");

    if(!dados.IsDBNull(dados.GetOrdinal("login")))
    user.login = dados.GetString("login");

    if(!dados.IsDBNull(dados.GetOrdinal("senha")))
    user.senha = dados.GetString("senha");

    }

    conexao.Close();

    return user;

    }
    }
}