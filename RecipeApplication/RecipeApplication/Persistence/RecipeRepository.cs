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
        public string ConnnectionString { get; set; }
        public void Create(Recipe recipe)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
            }
        }
        RecipeRepository()
        {
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            string? ConnectionString = config.GetConnectionString("MyDBConnection");
        }
    }
}
