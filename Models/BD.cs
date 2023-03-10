
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

namespace Pizzas.Api.Models
{
    public class BD
    {
        private static string _connectionString = @"Server=A-PHZ2-CIDI-014\SQLEXPRESS;DataBase=DAI-Pizzas;Trusted_Connection=True";

        public static List<Pizza> ObtenerPizzas()
        {
            List<Pizza> lista = new List<Pizza>();
             string sql = "SELECT * FROM Pizza";
             using(SqlConnection db = new SqlConnection(_connectionString)){
                 lista = db.Query<Pizza>(sql).ToList();
             }
             return lista;
        }

        public static List<Pizza> ObtenerPizzas(int IdPizza)
        {
            List<Pizza> lista = new List<Pizza>();
             string sql = "SELECT * FROM Pizza WHERE IdPizza = @pIdPizza";
             using(SqlConnection db = new SqlConnection(_connectionString)){
                 lista = db.Query<Pizza>(sql).ToList();
             }
             return lista;
        }

        public static void AgregarPelicula(Pizza pizza)
        {
            string sql = "INSERT INTO Pelicula VALUES (@pNombre, @pFoto, @pDescripcion, @pEstrellas, @pFkCategoria)";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                db.Execute(sql, new {pNombre = pizza.Nombre, pLibreGLuten = pizza.LibreGLuten, pImporte = pizza.Importe, pDescripcion = pizza.Descripcion });
            }
        }

        // public static List<Pizzas> ObtenerUsuarios()
        // {
        //     List<Pizzas> lista = new List<Pizzas>();
        //     string sql = "SELECT * FROM Usuario";
        //     using(SqlConnection db = new SqlConnection(_connectionString)){
        //         lista = db.Query<Pizzas>(sql).ToList();
        //     }
        //     return lista;
        // }
        // public static List<Pelicula> ObtenerTop()
        // {
        //     List<Pelicula> lista = new List<Pelicula>();
        //     string sql = "SELECT * FROM Pelicula WHERE Estrellas = 5";
        //     using(SqlConnection db = new SqlConnection(_connectionString)){
        //         lista = db.Query<Pelicula>(sql).ToList();
        //     }
        //     return lista;
        // }
        // public static Categoria ObtenerCategoria(int IdCategoria)
        // {
        //     Categoria categoria = null;
        //     string sql = "SELECT * FROM Categoria WHERE IdCategoria = @pIdCategoria";
        //     using(SqlConnection db = new SqlConnection(_connectionString)){
        //         categoria = db.QueryFirstOrDefault<Categoria>(sql, new { pIdCategoria = IdCategoria});
        //     }
        //     return categoria;
        // }


        // public static  List<Rese??a> ObtenerRese??as()
        // {
        //     List<Rese??a> lista = new List<Rese??a>();
        //     string sql = "SELECT Rese??a.Contenido, Rese??a.FkUsuario, Rese??a.FkPelicula, Usuario.Nombre as NombreUsuario FROM Rese??a inner join Usuario on Rese??a.FkUsuario = Usuario.IdUsuario";
        //     using(SqlConnection db = new SqlConnection(_connectionString)){
        //         lista = db.Query<Rese??a>(sql).ToList();
        //     }
        //     return lista;
        // }


        // public static  List<Categoria> ObtenerCategoria()
        // {
        //     List<Categoria> lista = new List<Categoria>();
        //     string sql = "SELECT * FROM Categoria";
        //     using(SqlConnection db = new SqlConnection(_connectionString)){
        //         lista = db.Query<Categoria>(sql).ToList();
        //     }
        //     return lista;
        // }


        // public static void AgregarPelicula(Pelicula Peli)
        // {
        //     string sql = "INSERT INTO Pelicula VALUES (@pNombre, @pFoto, @pDescripcion, @pEstrellas, @pFkCategoria)";
        //     using(SqlConnection db = new SqlConnection(_connectionString)){
        //         db.Execute(sql, new {pNombre = Peli.Nombre, pFoto = Peli.Foto, pDescripcion = Peli.Descripcion, pEstrellas = Peli.Estrellas, pFkCategoria = Peli.FkCategoria });
        //     }
        // }


        // public static void AgregarRese??a(Rese??a res)
        // {
        //     string sql = "INSERT INTO Rese??a VALUES (@pContenido, @pFkUsuario, @pFkPelicula)";
        //     using(SqlConnection db = new SqlConnection(_connectionString)){
        //         db.Execute(sql, new { pContenido = res.Contenido, pFkUsuario = res.FkUsuario, pFkPelicula = res.FkPelicula});
        //     }
        // }


        // public static void EliminarPelicula(int IdPelicula)
        // {
        //     int RegistrosEliminados = 0;
        //     string sql = "DELETE FROM Pelicula WHERE IdPelicula = @pIdPelicula ";
        //     using(SqlConnection db = new SqlConnection(_connectionString)){
        //         RegistrosEliminados = db.Execute(sql, new { pIdPelicula = IdPelicula});
        //     }
        // }
        // public static Pelicula VerInfoPelicula(int IdPelicula)
        // {
        //     Pelicula peli = null;
        //     string sql = "SELECT * FROM Pelicula WHERE IdPelicula = @pIdPelicula";
        //     using(SqlConnection db = new SqlConnection(_connectionString)){
        //         peli = db.QueryFirstOrDefault<Pelicula>(sql, new { pIdPelicula = IdPelicula});
        //     }
        //     return peli;
        // }
        // public static void AgregarUsuario(string nombre)
        // {
        //     string sql = "INSERT INTO Usuario VALUES (@pNombre)";
        //     using(SqlConnection db = new SqlConnection(_connectionString)){
        //         db.Execute(sql, new { pNombre = nombre});
        //     }
        // }

    }
}

