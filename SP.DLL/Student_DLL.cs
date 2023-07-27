using DTO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SP.Entites;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SP.DLL
{
    public class StudentD : IStudentD
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionstring;
        public StudentD(IConfiguration Configuration)
        {
            _configuration = Configuration;
            _connectionstring = _configuration.GetConnectionString("DataBase");
        }
        public object getEmploye()
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("sp_getData", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<StudentDBModel> data = new List<StudentDBModel>();
                        while (reader.Read())
                        {
                            StudentDBModel employee = new StudentDBModel()
                            {
                                StudId = reader.GetInt32("StudId"),
                                StudName = reader.GetString("StudName"),
                                StudAge = reader.GetInt32("StudAge"),
                                StudFees = reader.GetInt32("StudFees")
                            };
                            data.Add(employee);
                        }
                        connection.Close();
                        return data;
                    }
                }
            }
        }

        public object PostSpMethod(ViewModel studentDBModel)
        {
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                using (SqlCommand con2 = new SqlCommand("SP_InsertStudDetails", con))
                {
                    con2.CommandType = CommandType.StoredProcedure;
                    con2.Parameters.AddWithValue("@Name", studentDBModel.StudName);
                    con2.Parameters.AddWithValue("@Age", studentDBModel.StudAge);
                    con2.Parameters.AddWithValue("@Fees", studentDBModel.StudFees);
                    con2.ExecuteNonQuery();
                    con.Close();
                    return studentDBModel;
                }
            }
        }

        public object PutSpMethod(StudentDBModel studentDBModel)
        {
            
            using (SqlConnection con1 = new SqlConnection(_connectionstring))
            {
                con1.Open();
                using (SqlCommand con2 = new SqlCommand("SP_UpdateStudDetails", con1))
                {
                    con2.CommandType = CommandType.StoredProcedure;
                    con2.Parameters.AddWithValue("@id", studentDBModel.StudId);
                    con2.Parameters.AddWithValue("@Name", studentDBModel.StudName);
                    con2.Parameters.AddWithValue("@Age", studentDBModel.StudAge);
                    con2.Parameters.AddWithValue("@Fees", studentDBModel.StudFees);
                    con2.ExecuteNonQuery();
                    con1.Close();
                    return studentDBModel;
                }
            }
        }
        public object DeleteSpMethod(int id)
        {
            using (SqlConnection con1 = new SqlConnection(_connectionstring))
            {
                con1.Open();
                using (SqlCommand con2 = new SqlCommand("SP_DeleteStudDetails", con1))
                {
                    con2.CommandType = CommandType.StoredProcedure;
                    con2.Parameters.AddWithValue("@id", id);
                    con2.ExecuteNonQuery();
                    con1.Close();
                    return "Record Delete Sucessfully";
                }
            }
        }
    }
}
