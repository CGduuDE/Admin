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
    
    public partial class PO : Window
    {
        static sql_request sql = new sql_request();
        //MyViewModel viewModel = new MyViewModel();
        
        string path = "";
        string lg = "";
        
        public PO()
        {
            InitializeComponent();
            //this.DataContext = new MyViewModel();
        }

        class Cabinet
        {
            public string cabinet
            {
                get { return sql.get_logo("cabinet"); }
            }
        }
        class CSGO
        {
            public string csgo
            {
                get { return sql.get_logo("csgo"); }
            }
        }
        class Browser
        {
            public string browser
            {
                get { return sql.get_logo("browser"); }
            }
        }
        class Discord
        {
             public string discord
            {
                get { return sql.get_logo("discord"); }
            }

        }
        class Dota2
        {
            public string dota2
            {
                get { return sql.get_logo("dota2"); }
            }
        }
        class Pubg
        {
            public string pubg
            {
                get { return sql.get_logo("pubg"); }
            }
        }
        class Faceit
        {
            public string faceit
            {
                get { return sql.get_logo("faceit"); }
            }
        }
        class LoL
        {
            public string lol
            {
                get { return sql.get_logo("lol"); }
            }
        }
        class Warface
        {
            public string warface
            {
                get { return sql.get_logo("warface"); }
            }
        }
        class Steam
        {
            public string steam
            {
                get { return sql.get_logo("steam"); }
            }
        }
        class Origin
        {
            public string origin
            {
                get { return sql.get_logo("origin"); }
            }
        }
        class Battlenet
        {
            public string battlenet
            {
                get { return sql.get_logo("battlenet"); }
            }
        }
        class WoT
        {
            public string wot
            {
                get { return sql.get_logo("wot"); }
            }
        }
        class WarGaming
        {
            public string wargaming
            {
                get { return sql.get_logo("wargaming"); }
            }
        }
        class TS3
        {
            public string ts3
            {
                get { return sql.get_logo("ts3"); }
            }
        }
        class EpicGames
        {
            public string epicgames
            {
                get { return sql.get_logo("epicgames"); }
            }
        }
        class Mouse
        {
            public string mouse
            {
                get { return sql.get_logo("mouse"); }
            }
        }
        class Sound
        {
            public string sound
            {
                get { return sql.get_logo("sound"); }
            }
        }
        class Nvidia
        {
            public string nvidia
            {
                get { return sql.get_logo("nvidia"); }
            }
        }
        class _Out
        {
            public string _out
            {
                get { return sql.get_logo("out"); }
            }
        }
       /* class MyViewModel
        {
            public string cabinet
            {
                get { return sql.get_logo("cabinet"); }
            }
            public string csgo
            {
                get { return sql.get_logo("csgo"); }
            }
            public string browser
            {
                get { return sql.get_logo("browser"); }
            }
            public string discord
            {
                get { return sql.get_logo("discord"); }
            }
            public string dota2
            {
                get { return sql.get_logo("dota2"); }
            }
            public string pubg
            {
                get { return sql.get_logo("pubg"); }
            }
            public string faceit
            {
                get { return sql.get_logo("faceit"); }
            }
            public string lol
            {
                get { return sql.get_logo("lol"); }
            }
            public string warface
            {
                get { return sql.get_logo("warface"); }
            }
            public string steam
            {
                get { return sql.get_logo("steam"); }
            }
            public string origin
            {
                get { return sql.get_logo("origin"); }
            }
            public string battlenet
            {
                get { return sql.get_logo("battlenet"); }
            }
            public string wot
            {
                get { return sql.get_logo("wot"); }
            }
            public string wargaming
            {
                get { return sql.get_logo("wargaming"); }
            }
            public string ts3
            {
                get { return sql.get_logo("ts3"); }
            }
            public string epicgames
            {
                get { return sql.get_logo("epicgames"); }
            }
            public string mouse
            {
                get { return sql.get_logo("mouse"); }
            }
            public string sound
            {
                get { return sql.get_logo("sound"); }
            }
            public string nvidia
            {
                get { return sql.get_logo("nvidia"); }
            }
            public string _out
            {
                get { return sql.get_logo("out"); }
            }
        }*/

        public void Skip(string name)
        {

            switch (name)
            {
                case "browser":
                    browser.Visibility = Visibility.Hidden;
                    break;
                case "discord":
                    discord.Visibility = Visibility.Hidden;
                    break;
                case "dota2":
                    dota2.Visibility = Visibility.Hidden;
                    break;
                case "csgo":
                    csgo.Visibility = Visibility.Hidden;
                    break;
                case "pubg":
                    pubg.Visibility = Visibility.Hidden;
                    break;
                case "faceit":
                    faceit.Visibility = Visibility.Hidden;
                    break;
                case "lol":
                    lol.Visibility = Visibility.Hidden;
                    break;
                case "warface":
                    warface.Visibility = Visibility.Hidden;
                    break;
                case "steam":
                    steam.Visibility = Visibility.Hidden;
                    break;
                case "origin":
                    origin.Visibility = Visibility.Hidden;
                    break;
                case "battlenet":
                    battlenet.Visibility = Visibility.Hidden;
                    break;
                case "wot":
                    wot.Visibility = Visibility.Hidden;
                    break;
                case "wargaming":
                    wargaming.Visibility = Visibility.Hidden;
                    break;
                case "ts3":
                    ts3.Visibility = Visibility.Hidden;
                    break;
                case "epicgames":
                    epicgames.Visibility = Visibility.Hidden;
                    break;
                case "sound":
                    sound.Visibility = Visibility.Hidden;
                    break;
                case "mouse":
                    mouse.Visibility = Visibility.Hidden;
                    break;
                case "nvidia":
                    nvidia.Visibility = Visibility.Hidden;
                    break;
                case "_out":
                    _out.Visibility = Visibility.Hidden;
                    break;
                default:
                    break;
            }
            
        }
        private void Button_Browser(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Browser();
            Skip(Name);
            
            browser.Visibility = Visibility.Visible;
            path = Path.Text = (sql.get_path("browser"));
            lg = Logo.Text = (sql.get_logo("browser"));
            Name = "browser";

        }
        private void Button_Discord(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Discord();
            Skip(Name);
            
            discord.Visibility = Visibility.Visible;
            path = Path.Text = (sql.get_path("discord"));
            lg = Logo.Text = (sql.get_logo("discord"));
            Name = "discord";

        }
        private void Button_Dota2(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Dota2();
            Skip(Name);
            
            dota2.Visibility = Visibility.Visible;
            path = Path.Text = (sql.get_path("dota2"));
            lg = Logo.Text = (sql.get_logo("dota2"));
            Name = "dota2";

        }
        private void Button_CSGO(object sender, RoutedEventArgs e)
        {
            this.DataContext = new CSGO();
            Skip(Name);
           
            csgo.Visibility = Visibility.Visible;
            path = Path.Text = (sql.get_path("csgo"));
            lg = Logo.Text = (sql.get_logo("csgo"));
            Name = "csgo";

        }
        private void Button_PUBG(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Pubg();
            Skip(Name);
            
            pubg.Visibility = Visibility.Visible;
            path = Path.Text = (sql.get_path("pubg"));
            lg = Logo.Text = (sql.get_logo("pubg"));
            Name = "pubg";

        }
        private void Button_FC(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Faceit();
            Skip(Name);
            
            faceit.Visibility = Visibility.Visible;
            path = Path.Text = (sql.get_path("faceit"));
            lg = Logo.Text = (sql.get_logo("faceit"));
            Name = "faceit";

        }
        private void Button_LOL(object sender, RoutedEventArgs e)
        {
            this.DataContext = new LoL();
            Skip(Name);
            
            lol.Visibility = Visibility.Visible;
            path = Path.Text = (sql.get_path("lol"));
            lg = Logo.Text = (sql.get_logo("lol"));
            Name = "lol";

        }
        private void Button_WARFACE(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Warface();
            Skip(Name);
            warface.Visibility = Visibility.Visible;
            path = Path.Text = (sql.get_path("warface"));
            lg = Logo.Text = (sql.get_logo("warface"));
            Name = "warface";
        }
        private void Button_Origin(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Origin();
            Skip(Name);
            origin.Visibility = Visibility.Visible;
            path = Path.Text = (sql.get_path("origin"));
            lg = Logo.Text = (sql.get_logo("origin"));
            Name = "origin";

        }
        private void Button_TS(object sender, RoutedEventArgs e)
        {
            this.DataContext = new TS3();
            Skip(Name);
            ts3.Visibility = Visibility.Visible;
            path = Path.Text = (sql.get_path("ts3"));
            lg = Logo.Text = (sql.get_logo("ts3"));
            Name = "ts3";
        }
        private void Button_EpicGames(object sender, RoutedEventArgs e)
        {
            this.DataContext = new EpicGames();
            Skip(Name);
            epicgames.Visibility = Visibility.Visible;
            path = Path.Text = (sql.get_path("epicgames"));
            lg = Logo.Text = (sql.get_logo("epicgames"));
            Name = "epicgames";
        }
        private void Button_BattleNet(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Battlenet();
            Skip(Name);
            battlenet.Visibility = Visibility.Visible;
            path = Path.Text = (sql.get_path("battlenet"));
            lg = Logo.Text = (sql.get_logo("battlenet"));
            Name = "battlenet";
        }
        private void Button_WoT(object sender, RoutedEventArgs e)
        {
            this.DataContext = new WoT();
            Skip(Name);

            wot.Visibility = Visibility.Visible;
            path = Path.Text = (sql.get_path("wot"));
            lg = Logo.Text = (sql.get_logo("wot"));
            Name = "wot";
        }
        private void Button_WarGaming(object sender, RoutedEventArgs e)
        {
            this.DataContext = new WarGaming();
            Skip(Name);

            wargaming.Visibility = Visibility.Visible;
            path = Path.Text = (sql.get_path("wargaming"));
            lg = Logo.Text = (sql.get_logo("wargaming"));
            Name = "wargaming";
        }
        private void Button_Steam(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Steam();
            Skip(Name);
            steam.Visibility = Visibility.Visible;
            path = Path.Text = (sql.get_path("steam"));
            lg = Logo.Text = (sql.get_logo("steam"));
            Name = "steam";
        }
        private void Button_Mouse(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Mouse();
            Skip(Name);
            mouse.Visibility = Visibility.Visible;
            path = Path.Text = (sql.get_path("mouse"));
            lg = Logo.Text = (sql.get_logo("mouse"));
            Name = "mouse";
        }
        private void Button_Sound(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Sound();
            Skip(Name);
            sound.Visibility = Visibility.Visible;
            path = Path.Text = (sql.get_path("sound"));
            lg = Logo.Text = (sql.get_logo("sound"));
            Name = "sound";
        }
        private void Button_Nvidia(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Nvidia();
            Skip(Name);
            nvidia.Visibility = Visibility.Visible;
            path = Path.Text = (sql.get_path("nvidia"));
            lg = Logo.Text = (sql.get_logo("nvidia"));
            Name = "nvidia";
        }
        private void Button_OUT(object sender, RoutedEventArgs e)
        {
            this.DataContext = new _Out();
            Skip(Name);
            _out.Visibility = Visibility.Visible;
            path = Path.Text = (sql.get_path("out"));
            lg = Logo.Text = (sql.get_logo("out"));
            Name = "_out";
        }
        private void Button_Save(object sender, RoutedEventArgs e)
        {
            if(lg == Logo.Text && path == Path.Text)
            {
                MessageBox.Show("Изменений не было!");
            }
            if(lg != Logo.Text)
            {
                sql.set_logo(Name, Logo.Text);
                MessageBox.Show("Лого изменен!");
            }
             if(path != Path.Text)
            {
                sql.set_path(Name, Path.Text);
                MessageBox.Show("Пусть изменен!");
            }
 
            /*if(sql.set_path(Name, Path.Text) && sql.set_logo(Name, Logo.Text))
            {
                MessageBox.Show("Успешно!");
            }*/
            //sql.set_path(Name, Path.Text);
           // sql.set_logo(Name, Logo.Text);
        }

    }
}
