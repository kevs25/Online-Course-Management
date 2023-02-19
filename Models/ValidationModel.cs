using System;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using Webapp.Models;
using System.Data;

namespace Webapp.Models
{
    public class ValidationModel
    {
        static ValidationModel()
        {
            using(SqlConnection connection = new SqlConnection("Data source =KEVIN; Database = signupDetails; Integrated security=SSPI"))
            {
                connection.Open();
                Console.WriteLine("Successfull");
                SqlCommand insertCommand = new SqlCommand("Insert into signupDetails values(@value1, @value2, @value3, @value4)",connection);
                insertCommand.Parameters.Add("@value1", SqlDbType.VarChar,50,"username").Value=username;
                insertCommand.Parameters.Add("@value2", SqlDbType.VarChar,50,"password").Value=password;
            
            }
        }
        public static int signupValidation()
        {
            Regex usernameValidation = new Regex(@"^[a-z]*$");
            Regex userpasswordValidation = new Regex(@"^(?=.?[A-Z])(?=.?[a-z])(?=.?[0-9])(?=.?[#?!@$%^&*-]).{8,}$");

            SignUpModel s = new SignUpModel();
            string? username = s.username;
            string? password = s.password;
            string? confirmPassword = s.ConfirmPassword;

            if(username is not null && username.Length >= 10 && usernameValidation.IsMatch(username) && password is not null && password.Length >= 10 && userpasswordValidation.IsMatch(password))
                if(String.Equals(password,confirmPassword))
                {
                    
                    return 1;
                }
                else
                    return 2;
            else
                return 2;
        
            
            //  {
            //      return 1;
                    
            //  }
            // else
            // {
            //     return 2;
            // }
         
        }
        
        
        
    }
}