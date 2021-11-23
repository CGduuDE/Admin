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
    /// Логика взаимодействия для price.xaml
    /// </summary>
    public partial class price : Window
    {
        sql_request sql = new sql_request();
        public price()
        {
            InitializeComponent();
            Price.Text = sql.get_price();
        }

        private void Button_Change_price(object sender, RoutedEventArgs e)
        {
            
            sql.change_price(Price.Text);
            Hide();
        }
    }
}
