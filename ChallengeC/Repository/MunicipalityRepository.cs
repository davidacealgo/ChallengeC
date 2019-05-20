using ChallengeC.Models;
using ChallengeC.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeC.Repository
{
    public class MunicipalityRepository
    {
        public static bool GetMunicipality(Municipality municipality)
        {
            var connectionString = "Data source=.;Initial Catalog=Challenge;Integrated Security=True";

            var query = "SELECT Names FROM Municipality";

            query = query.Replace("@Names", municipality.Names);

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                return true;
            }
            catch
            {
                //throw;
                return false;
            }
        }
    }
}
