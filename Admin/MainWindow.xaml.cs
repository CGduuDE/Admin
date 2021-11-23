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
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace Admin
{


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void Button_Auth(object sender, RoutedEventArgs e)
        {
            
            string login = Login.Text.Trim();
            string password = Password.Text.Trim();
            if (login == "admin" && password == "123")
            {
                
                AuthWindow authwindow = new AuthWindow();
                authwindow.Show();
                Hide();
            }
            else 
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            
        }

       
    }
}
