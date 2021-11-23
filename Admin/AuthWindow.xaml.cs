using System;
using System.IO;
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
using System.Windows.Interop;
using System.Runtime.InteropServices;

namespace Admin
{
    
    public partial class AuthWindow : Window
    {
        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);

            HwndSource hwndSource = PresentationSource.FromVisual(this) as HwndSource;

            if (hwndSource != null)
            {
                hwndSource.AddHook(HwndSourceHook);
            }

        }

        private bool allowClosing = false;

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32.dll")]
        private static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);

        private const uint MF_BYCOMMAND = 0x00000000;
        private const uint MF_GRAYED = 0x00000001;

        private const uint SC_CLOSE = 0xF060;

        private const int WM_SHOWWINDOW = 0x00000018;
        private const int WM_CLOSE = 0x10;

        private IntPtr HwndSourceHook(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            switch (msg)
            {
                case WM_SHOWWINDOW:
                    {
                        IntPtr hMenu = GetSystemMenu(hwnd, false);
                        if (hMenu != IntPtr.Zero)
                        {
                            EnableMenuItem(hMenu, SC_CLOSE, MF_BYCOMMAND | MF_GRAYED);
                        }
                    }
                    break;
                case WM_CLOSE:
                    if (!allowClosing)
                    {
                        handled = true;
                    }
                    break;
            }
            return IntPtr.Zero;
        }


        private void Window1_SourceInitialized(object sender, EventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            HwndSource source = HwndSource.FromHwnd(helper.Handle);
            source.AddHook(WndProc);
        }

        const int WM_SYSCOMMAND = 0x0112;
        const int SC_MOVE = 0xF010;

        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {

            switch (msg)
            {
                case WM_SYSCOMMAND:
                    int command = wParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                    {
                        handled = true;
                    }
                    break;
                default:
                    break;
            }
            return IntPtr.Zero;
        }

        public AuthWindow()
        {
            InitializeComponent();
             
        }

        sql_request sql = new sql_request();
      
        private void Button_Money(object sender, RoutedEventArgs e)
        {

            Money money = new Money();
            money.Show();

        }

        private void Button_Register(object sender, RoutedEventArgs e)
        {

            Register register = new Register();
            register.Show();

        }

        private void Button_Change_Padssword(object sender, RoutedEventArgs e)
        {
            
            Change_Password change_password = new Change_Password();
            change_password.Show();

        }

        private void Button_Reboot_PC(object sender, RoutedEventArgs e)
        {
            if(id_pc.Text != "Номер пк" && id_pc.Text != "")
            {
                sql.set_command("Shutdown /r /t 0", id_pc.Text);
            }
            else
            {
                MessageBox.Show("Введите номер пк!");
            }
        }

        private void Button_OFF_PC(object sender, RoutedEventArgs e)
        {
            if (id_pc.Text != "Номер пк" && id_pc.Text != "")
            {
                sql.set_command("Shutdown /s /t 0", id_pc.Text);
            }
            else
            {
                MessageBox.Show("Введите номер пк!");
            }
        }

        private void Button_Task_Manager(object sender, RoutedEventArgs e)
        {
            if (id_pc.Text != "Номер пк" && id_pc.Text != "")
            {
                sql.set_command("taskmgr.exe", id_pc.Text);
            }
            else
            {
                MessageBox.Show("Введите номер пк!");
            }
        }

        private void Button_Conductor(object sender, RoutedEventArgs e)
        {
            if (id_pc.Text != "Номер пк" && id_pc.Text != "")
            {
                sql.set_command("Explorer", id_pc.Text);
            }
            else
            {
                MessageBox.Show("Введите номер пк!");
            }
        }

        private void Button_Financial_Report(object sender, RoutedEventArgs e)
        {
             
            sql_request sql = new sql_request();
            sql.financial_report();
            //Environment.Exit(0);
        }

        private void Button_PO(object sender, RoutedEventArgs e)
        {
            PO po = new PO();
            po.Show();
        }

        private void Button_OUT(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Price(object sender, RoutedEventArgs e)
        {
            price pr = new price();
            pr.Show();
        }
    }
}
