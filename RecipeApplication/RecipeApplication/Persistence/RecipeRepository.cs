using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeApplication.Model;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;



namespace RecipeApplication.Persistence
{
    public class RecipeRepository
    {
        public string ConnectionString { get; set; }
        public void Create(Recipe r)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Recipe(Name, Description)"
                    + "VALUES (@Name, @Description)"
                    + "SELECT (@@IDENTITY)", con);
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = r.Name;
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = r.Description;
                r.RecipeId = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        RecipeRepository()
        {
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            string? ConnectionString = config.GetConnectionString("MyDBConnection");
        }
    }
}
