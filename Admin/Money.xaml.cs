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
using System.IO;
namespace Admin
{

    public partial class Money : Window
    {
        bool card = false;
        bool nal = false;
        
        public Money()
        {
            InitializeComponent();
        }

        private void Button_Add_Money(object sender, RoutedEventArgs e)
        {
            sql_request sql = new sql_request();
            string login = Login.Text.Trim();
            int summ = Convert.ToInt32(Summ.Text.Trim());
            
            if (card)
            {
                sql.add_money(login, summ, "card");
                
            }
            if (nal)
            {
                sql.add_money(login, summ, "cash");
                                
            }
            else if (!nal && !card)
            {
                MessageBox.Show("Необходимо выбрать способ оплаты!");
            }
            card = false;
            nal = false;

            Hide();
        }

        private void Summ_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_Checked1(object sender, RoutedEventArgs e)
        {
            nal = true;
            //MessageBox.Show("NAL");
        }

        private void RadioButton_Checked2(object sender, RoutedEventArgs e)
        {
            card = true;
            //MessageBox.Show("CARD");
        }
    }
}
