using ApiCarros.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Principal;

namespace ApiCarros.DataBase
{
    public class dbAdo
    {
        protected string connectionString;
        public void configDb()
        {
            connectionString = "data source = localhost ;User ID = sa;Password =lgr1234$;Initial Catalog = ApiCarros; ";
        }

        //public List<Marca> Marca()
        //{
        //    List<Marca> marcas = new List<Marca>();
        //    configDb();
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        string sql = "SELECT * FROM  Marcas";
        //        using (SqlCommand command = new SqlCommand(sql, connection))
        //        {
        //            connection.Open();
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
                        
        //                while (reader.Read())
        //                {

        //                   marcas.Add(new Marca() { id = (int)reader[2],nome = (string)reader[0],codigo = (string)reader[1]});

        //                }
        //                reader.Close();

        //                return marcas;
        //            }
        //        }
        //    }
        //}

        public List<marcasFabricacao> marcasFabricacao()
        {
            List<marcasFabricacao> marcasFabricacaos = new List<marcasFabricacao>();
            configDb();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "select * from marcasFabricacao";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            marcasFabricacaos.Add(new marcasFabricacao() {marcas = (string)reader[1] , AnoFabricacao = (string)reader[2] });

                        }
                        reader.Close();

                        return marcasFabricacaos;
                    }
                }
            }
        }

        public List<MarcaAnoFabricacaoModelo> MarcasAnoFabricacaoModelo()
        {
            List<MarcaAnoFabricacaoModelo> MarcasAnoFabricacaoModelos = new List<MarcaAnoFabricacaoModelo>();
            configDb();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "select * from MarcanoFabricacaoModelo";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            MarcasAnoFabricacaoModelos.Add(new MarcaAnoFabricacaoModelo() { marcas = (string)reader[1], AnoFabricacao = (string)reader[2] , AnoModelo = (string)reader[3] });

                        }
                        reader.Close();

                        return MarcasAnoFabricacaoModelos;
                    }
                }
            }
        }


        public List<Modelo> Modelo()
        {
            List<Modelo> Modelos = new List<Modelo>();
            configDb();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "select * from Modelos";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            Modelos.Add(new Modelo() { marcas = (string)reader[1], AnoFabricacao = (string)reader[2], AnoModelo = (string)reader[3] , modelo = (string)reader[4] });

                        }
                        reader.Close();

                        return Modelos;
                    }
                }
            }
        }


        public List<Versao> Versoes()
        {
            List<Versao> versoes = new List<Versao>();
            configDb();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "select * from Versao";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            versoes.Add(new Versao() { 
                                        marcas = (string)reader[1], 
                                        AnoFabricacao = (int)reader[2], 
                                        AnoModelo = (int)reader[3], 
                                        modelo = (string)reader[4], 
                                        versao=(string)reader[5],
                                        codigoFipe= (string)reader[6],
                            });

                        }
                        reader.Close();

                        return versoes;
                    }
                }
            }
        }
    }
}
