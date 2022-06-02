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

namespace Sharp_Emblem
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            /*using (var db = new sharpemblemContext())
            {
                var user = db.Users.FirstOrDefault(user => user.Naam == UserName.Text);
                if (user == null)
                {
                    MessageBox.Show("Username does not exist or password doesn't match.");
                }
                else
                {
                    if (PassWord.Password == user.Password)
                    {
                        MainWindow program = new MainWindow();
                        program.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username does not exist or password doesn't match.");
                    }
                }
            }*/

            MainWindow program = new MainWindow();
            program.Show();
            this.Close();
        }
    }
}
