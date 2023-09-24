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

namespace xaml_design
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataBase dataBase = new DataBase();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Registr_Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginBox.Text.Trim();
            string password = PasswordBox.Password.Trim();
            string password2 = repPassw.Password.Trim();
            string email = EmailBox.Text.ToLower().Trim();
            int count = 0;

            if(login.Length < 5)
            {
                LoginBox.ToolTip = "Логин должен быть не менее 5-ти символов";
                LoginBox.Background = Brushes.DarkRed;
                count++;
            }
            else
            {
                LoginBox.ToolTip = "";
                LoginBox.Background = Brushes.Transparent;
            }

            if(password.Length < 5 || password.Any(Char.IsUpper))
            {
                PasswordBox.ToolTip = "Пароль должен быть не менее 5-ти символов";
                PasswordBox.Background = Brushes.DarkRed;
                count++;
            }
            else
            {
                PasswordBox.ToolTip = "";
                PasswordBox.Background = Brushes.Transparent;

            }

            if (password != password2 || password2.Length < 5)
            {

                repPassw.ToolTip = "Пароли должны совпадать";
                repPassw.Background = Brushes.DarkRed;
                count++;
            }
            else
            {
                repPassw.ToolTip = "";
                repPassw.Background = Brushes.Transparent;
            }
            if (email.Length < 5 || !email.Contains('@') || !email.Contains('.'))
            {

                EmailBox.ToolTip = "Email введён неккоректно";
                EmailBox.Background = Brushes.DarkRed;
                count++;
            }
            else
            {
                EmailBox.ToolTip = "";
                EmailBox.Background = Brushes.Transparent;
            }
            if(count == 0)
            {
                MessageBox.Show("Вы успешно зарегистрировались");
            }

        }
    }
}
