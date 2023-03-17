using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

namespace Pizzas.Api.Models
{
    public class BD
    {
        private static string _connectionString = @"Server=A-PHZ2-CIDI-020;DataBase=DAI-Pizzas;Trusted_Connection=True";

        public static List<Pizza> ObtenerPizzas()
        {
            List<Pizza> lista = new List<Pizza>();
             string sql = "SELECT * FROM Pizzas";
             using(SqlConnection db = new SqlConnection(_connectionString))
            {
                lista = db.Query<Pizza>(sql).ToList();
            }
             return lista;
        }

        public static List<Pizza> ObtenerPizzasId(int Id)
        {
            List<Pizza> lista = new List<Pizza>();
             string sql = "SELECT * FROM Pizzas WHERE Id = @pId";
             using(SqlConnection db = new SqlConnection(_connectionString)){
                 lista = db.Query<Pizza>(sql, new {pId = Id}).ToList();
             }
             return lista;
        }
        public static int AgregarPizza(Pizza pizza) 
        {
        
            string sqlQuery;

            int intRowsAffected = 0;

            sqlQuery = "INSERT INTO Pizzas (";

            sqlQuery += " Nombre , LibreGluten , Importe , Descripcion";

            sqlQuery += ") VALUES (";

            sqlQuery += " @pNombre , @pLibreGluten , @pImporte , @pDescripcion";

            sqlQuery += ")";

            using (SqlConnection db = new SqlConnection(_connectionString))
            {
            
                intRowsAffected = db.Execute(sqlQuery, new { pNombre = pizza.Nombre, pLibreGluten = pizza.LibreGluten, pImporte = pizza.Importe, pDescripcion = pizza.Descripcion});
                return intRowsAffected;
            }

        }

       public static Pizza Actualizar(int Id, Pizza pizza)
        {
            string sql = "UPDATE Pizzas SET Nombre = @pNombre, LibreGluten = @pLibreGluten , Importe = @pImporte, Descripcion = @pDescripcion WHERE Id = @pId ";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                pizza = db.QueryFirstOrDefault<Pizza>(sql, new { pId = pizza.Id, pNombre = pizza.Nombre, pLibreGluten = pizza.LibreGluten, pImporte = pizza.Importe, pDescripcion = pizza.Descripcion});
            }
            return pizza;
        }

        public static int EliminarId(int Id)
        {
            int RegistrosEliminados = 0;
            string sql = "DELETE FROM Pizzas WHERE Id = @pId ";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                RegistrosEliminados = db.Execute(sql, new { pId = Id});
            }
            return  RegistrosEliminados;
        }

        // public static int AgregarPizza(Pizza pizza)
        // {
        //     string sqlQuery;
        //     int devolver = 0;
        //     sqlQuery = "INSERT INTO Pizzas (";

        //     sqlQuery += " Nombre , LibreGluten , Importe , Descripcion";
         
        //     sqlQuery += ") VALUES (";
         
        //     sqlQuery += " @pNombre , @pLibreGluten , @pImporte , @dDescripcion";
         
        //     sqlQuery += ")";
        //     using(SqlConnection db = new SqlConnection(CONNECTION_STRING)){
        //         devolver = db.Execute(sqlQuery, new {pNombre = pizza.Nombre, pLibreGluten = pizza.LibreGluten, pImporte = pizza.Importe, pDescripcion = pizza.Descripcion });
        //     }
        //     return devolver;
        // }

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


        // public static  List<Reseña> ObtenerReseñas()
        // {
        //     List<Reseña> lista = new List<Reseña>();
        //     string sql = "SELECT Reseña.Contenido, Reseña.FkUsuario, Reseña.FkPelicula, Usuario.Nombre as NombreUsuario FROM Reseña inner join Usuario on Reseña.FkUsuario = Usuario.IdUsuario";
        //     using(SqlConnection db = new SqlConnection(_connectionString)){
        //         lista = db.Query<Reseña>(sql).ToList();
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


        // public static void AgregarReseña(Reseña res)
        // {
        //     string sql = "INSERT INTO Reseña VALUES (@pContenido, @pFkUsuario, @pFkPelicula)";
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

