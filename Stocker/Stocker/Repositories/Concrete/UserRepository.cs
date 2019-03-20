using Stocker.Models;
using Stocker.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Stocker.Repositories.Concrete
{
    public class UserRepository : IUserRepository
    {
        public string ConnectionString = "!!!!!!!!!!!!!";

        public bool AddUpdate(User user)
        {
            throw new NotImplementedException();
        }

        public User Authenticate(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                //create a command to send to the database
                using (SqlCommand cmd = new SqlCommand("spAuthenticateUser", connection))
                {
                    //adapt the command to use a stored procedure with parameters.
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@Email", System.Data.SqlDbType.VarChar));
                    adapter.SelectCommand.Parameters["@Email"].Value = email;
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@Password", System.Data.SqlDbType.VarChar));
                    adapter.SelectCommand.Parameters["@Password"].Value = password;

                    //bool correct = UserManager.Authenticate(Email,Password)
                    //
                    //If(correct) = Login else unable to login

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        //make user with data from db
                        User u = new User();
                        u.Email = email;
                        
                        return new User();
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public bool Delete(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetById(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
