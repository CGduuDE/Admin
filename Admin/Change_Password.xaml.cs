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
    /// <summary>
    /// Логика взаимодействия для Change_Password.xaml
    /// </summary>
    public partial class Change_Password : Window
    {
        public Change_Password()
        {
            InitializeComponent();
        }

        private void Button_Change_Password(object sender, RoutedEventArgs e)
        {
            sql_request sql = new sql_request();

            string login = Login.Text.Trim();
            string new_password = New_Password.Text.Trim();

            sql.change_password(login,new_password);

            Hide();
        }

        
    }
}
