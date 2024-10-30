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
        public async static Task<bool> NewAccountAdd(TextBox TBoxUsername, TextBox TBoxEmail, PasswordBox PBoxPassword)
        {   
            // validation email + password
            // 
            
            bool flagUsername = await(DataAccess.CheckValueExists("Username", TBoxUsername.Text));
            bool flagEmail = await(DataAccess.CheckValueExists("Email", TBoxEmail.Text));

            if (!flagUsername && !flagEmail)
            {
                await DataAccess.InputParams(TBoxUsername.Text, PBoxPassword.Password, TBoxEmail.Text);
                //MessageBox.Show("successfully!");
                return true;
            }

            //MessageBox.Show("such a user already exists!");
            return false;
            
            
        }
    }
    static class LogIn 
    {
        public async static Task<bool> HasAccount(TextBox textBox, PasswordBox passwordBox)
        {
            bool flagUsername = await (DataAccess.CheckValueExists("Username",textBox.Text));
            if (flagUsername)
            {
                return await DataAccess.IsValidPassword(textBox.Text, passwordBox.Password);
            }
            return false;
        }
    }
}
