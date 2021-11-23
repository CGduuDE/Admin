using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;
namespace Admin
{

    class sql_request
    {
        MySqlConnection mysqlConn = new MySqlConnection("server=188.120.228.37;uid=root;port=3306;pwd=fM6kK3bB3phQ;database=admin;");
        string sql = "";

        public bool change_price(string price)
        {
            try
            {
                mysqlConn.Open();

                sql = "update prices set price = '" + price + "'";
                MySqlCommand command = new MySqlCommand(sql, mysqlConn);
                command = new MySqlCommand(sql, mysqlConn);
                command.ExecuteNonQuery();

                MessageBox.Show("Тариф успешно изменен!");

              
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }

            mysqlConn.Close();
            return true;
        }
        public string get_price()
        {
            string price = "";
            try
            {
                mysqlConn.Open();

                sql = "select price from prices"; //select count(1) from users where login = 'test';

                MySqlCommand command = new MySqlCommand(sql, mysqlConn);

                price = command.ExecuteScalar().ToString();
            }

            catch
            {

                // MessageBox.Show("Ошибка!");

            }

            mysqlConn.Close();
            return price;
        }
        public void request_to_registr(string login, string password, string name)
        {
            if (check_user_existence(login) == false)
            {
                try
               {

                    mysqlConn.Open();
                    sql = "insert into users(login, password,name,balance) values('" + login + "','" + password + "','" + name + "','"+0+"')";


                    MySqlCommand command = new MySqlCommand(sql, mysqlConn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Новый пользователь зарегистрирован!");

                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }

                mysqlConn.Close();
            }
            else
            {
                MessageBox.Show("Такой пользователь уже существует!");
            }
        }
        public bool add_money(string login, int summ, string way)
        {
           if (check_user_existence(login) == true)
           {
                try
                {
                mysqlConn.Open();


                sql = "select balance from users where login = '" + login + "'";
                MySqlCommand command = new MySqlCommand(sql, mysqlConn);
                string otv = command.ExecuteScalar().ToString();
                
                

                double totallsumm = 0;
                if (otv == "")
                {
                    totallsumm += summ;
                }

                else
                {
                    otv = otv.Replace(".", ",");                        
                    totallsumm = summ + Convert.ToDouble(otv);
                }
                
                sql = "update users set balance = '" + Convert.ToString(totallsumm) + "' where login = '" + login + "'";
                command = new MySqlCommand(sql, mysqlConn);
                command.ExecuteNonQuery();
                MessageBox.Show("Счет успешно пополнен!\nСпособ: " + way);



                string data = DateTime.Now.ToString("T");
                sql = "insert into Financial_report(data,summ,login,way) values('" + data + "','" + Convert.ToString(summ) + "', '" + login + "','" + way + "')"; //DateTime.Now.ToString("T") - время

                command = new MySqlCommand(sql, mysqlConn);
                command.ExecuteNonQuery();

                mysqlConn.Close();
                return true;



                }
                catch
                {
                MessageBox.Show("Ошибка!");
                }
           }

                else
                {
                MessageBox.Show("Такого пользователя не существует!");
                    
                }
                mysqlConn.Close();
                return false;
         }      
        public void set_command(string my_command,string id)
        {
            //id = "0";
            try
            {
                mysqlConn.Open();

                sql = "update commands set command = '" + my_command + "' where id = '" + id + "'";
                MySqlCommand command = new MySqlCommand(sql, mysqlConn);
                command = new MySqlCommand(sql, mysqlConn);
                command.ExecuteNonQuery();

                //MessageBox.Show("Пароль успешно изменен!");

            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
            mysqlConn.Close();
        }
        private bool check_user_existence(string login)
        {

            bool exists = false;

            try
            {
                mysqlConn.Open();

                sql = "select count(1) from users where login = '" + login + "'"; //select count(1) from users where login = 'test';

                MySqlCommand command = new MySqlCommand(sql, mysqlConn);

                string otv = command.ExecuteScalar().ToString();

                if (Convert.ToInt32(otv) == 0) 
                {
                    exists = false; // пользователя не существует
                }
                else
                {
                    exists = true;
                }
            }

            catch
            {

                MessageBox.Show("Ошибка!");

            }

            mysqlConn.Close();
            return exists;
            
        }
        public void financial_report()
        {
            string report ="";
            sql = "SELECT * FROM Financial_report";
            try
            {
                mysqlConn.Open();
                MySqlCommand command = new MySqlCommand(sql, mysqlConn);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        object data = reader.GetValue(0);
                        object summ = reader.GetValue(1);
                        object login = reader.GetValue(2);
                        object way = reader.GetValue(3);

                        report += "\nВремя: " + Convert.ToString(data) + " Сумма: " + Convert.ToString(summ) + " Логин: " + Convert.ToString(login) + " Способ оплаты: " + Convert.ToString(way);

                    }

                    MessageBox.Show(report);
                     
                }
                else
                {
                    MessageBox.Show("Данных нет!");
                }
                
                reader.Close();

                sql = "delete from Financial_report";
                command = new MySqlCommand(sql, mysqlConn);
                command.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
            mysqlConn.Close();

        }
        public void change_password(string login, string password)
        {
            if (check_user_existence(login) == true)
            {

                try
                {
                    mysqlConn.Open();

                    sql = "update users set password = '" + password + "' where login = '" + login + "'";
                    MySqlCommand command = new MySqlCommand(sql, mysqlConn);
                    command = new MySqlCommand(sql, mysqlConn);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Пароль успешно изменен!");

                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }

            }
            else
            {
                MessageBox.Show("Такого пользователя не существует!");
            }

            mysqlConn.Close();
        }
        public string get_path(string name)
        {

            string path = "";
            try
            {
                mysqlConn.Open();

                sql = "select path from paths where name = '" + name + "'"; //select count(1) from users where login = 'test';

                MySqlCommand command = new MySqlCommand(sql, mysqlConn);

                path = command.ExecuteScalar().ToString();
            }

            catch
            {

                // MessageBox.Show("Ошибка!");

            }

            mysqlConn.Close();
            return path;
        }
        public bool set_path(string name,string path)

        {
            
           try
          {
             mysqlConn.Open();

             sql = "update paths set path = '" + path + "' where name = '" + name + "'";
             MySqlCommand command = new MySqlCommand(sql, mysqlConn);
             command = new MySqlCommand(sql, mysqlConn);
             command.ExecuteNonQuery();

             mysqlConn.Close();
             return true;
                

           }
            catch
            {
               MessageBox.Show("Ошибка!");
            }

            mysqlConn.Close();
            return false;
        }
        public string get_logo(string name)
        {

           try
            {
                mysqlConn.Open();
                sql = "select path from logo  where name = '" + name + "'"; //select balance from users  where login = 'test'

                MySqlCommand command = new MySqlCommand(sql, mysqlConn);

                name = command.ExecuteScalar().ToString();
                mysqlConn.Close();
                return name;
            }

            catch
            {

                MessageBox.Show("Ошибка!");

           }

            mysqlConn.Close();
            return name;
        }
        public bool set_logo(string name,string path)
        {
           try
            {
                mysqlConn.Open();

                sql = "update logo set path = '" + path + "' where name = '" + name + "'";
                MySqlCommand command = new MySqlCommand(sql, mysqlConn);
                command = new MySqlCommand(sql, mysqlConn);
                command.ExecuteNonQuery();

                mysqlConn.Close();
                return true;
                //MessageBox.Show("Путь успешно изменен!");

           }
           catch
            {
                MessageBox.Show("Ошибка!");
            }

            
            mysqlConn.Close();
            return false;
        }

    }
}