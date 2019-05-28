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

namespace School
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        SchoolEntities db = new SchoolEntities();

        public Login()
        {
            InitializeComponent();
        }

        private void login(object sender, RoutedEventArgs e)
        {
            var user = db.Users.FirstOrDefault(o => o.Username == usernameTextBox.Text && o.Password == passwordTextBox.Password);
            if (user == null)
            {
                MessageBox.Show("Username or Password is invalid");
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
       
        }
    }
}
