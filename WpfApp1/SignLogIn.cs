using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    static class SignIn
    {
        public async static Task<bool> NewAccountAdd(string username, string email, string password)
        {   
            // validation email + password
            // 
            
            bool flagUsername = await(DataAccess.CheckValueExists("Username", username));
            bool flagEmail = await(DataAccess.CheckValueExists("Email", email));

            if (!flagUsername && !flagEmail)
            {
                await DataAccess.InputParams(username, password, email);
                //MessageBox.Show("successfully!");
                return true;
            }

            //MessageBox.Show("such a user already exists!");
            return false;
            
            
        }
    }
    static class LogIn 
    {
        public async static Task<bool> HasAccount(string username, string password)
        {
            bool flagUsername = await (DataAccess.CheckValueExists("Username",username));
            if (flagUsername)
            {
                return await DataAccess.IsValidPassword(username, password);
            }
            return false;
        }
    }
}
