using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Dental_Clinic_Information_System
{
    public static class DBConnection
    {
        private static readonly string connectionString =
            @"Server=.\SQLEXPRESS; Database=DentalClinic; Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
