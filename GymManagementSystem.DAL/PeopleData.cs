using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL
{
    public static class PeopleData
    {
        public static bool IsPhoneNumberExists(string phoneNumber)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command =new SqlCommand("sp_People_IsPhoneNumberExists",connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 11).Value = phoneNumber;

                    connection.Open();

                    return Convert.ToBoolean(command.ExecuteScalar());
                }
            }
        }

        public static bool IsPhoneExistsForOtherPerson(string phoneNumber,int personID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(
                    "sp_People_IsPhoneNumberExistsForOtherPerson",connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@PhoneNumber",SqlDbType.VarChar,11).Value = phoneNumber;

                    command.Parameters.Add("@PersonID",SqlDbType.Int).Value = personID;

                    connection.Open();

                    return Convert.ToBoolean(command.ExecuteScalar());
                }
            }
        }
    }
}
