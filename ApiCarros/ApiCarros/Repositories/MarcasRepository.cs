using ApiCarros.Interfaces.Repositories;
using ApiCarros.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCarros.Repositories
{
    public class MarcasRepository : DataBase.dbAdo , IMarcaRepository
    {
        public List<Task<Marca>> BuscarMarcas(Marca model)
        {
            List<Marca> marcas = new List<Marca>();
            using SqlConnection conn = new SqlConnection(connectionString);
            {
                string strSql = "SELECT * FROM Marcas";
                using (SqlCommand command = new SqlCommand(strSql, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            marcas.Add(new Marca() { id = (int)reader[2], nome = (string)reader[0], codigo = (string)reader[1] });

                        }
                        reader.Close();

                        return marcas;
                    }

                }

            }

        }
    }
}
