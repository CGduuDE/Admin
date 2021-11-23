using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Admin
{

    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

       

        private void Button_Register(object sender, RoutedEventArgs e)
        {
            sql_request sql = new sql_request();
            
            string login = Login.Text.Trim();
            string password = Password.Text.Trim();
            string name = Name.Text.Trim();
       
            sql.request_to_registr(login,password,name);

            Hide();
        }
    }
}
