using System.Windows;
using WpfApp1.Models;
namespace WpfApp1
{
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        public void OnRegister(object sender, RoutedEventArgs e)
        {
            var entry = new User();
            if (RoleChooser.Text == "Пользователь")
            {
                entry.Role = 1;
            }
            else
            {
                entry.Role = 2;
            }
            entry.Login = LoginInput.Text;
            entry.Password = PasswordInput.Text;
            entry.Name = FNameInput.Text;
            entry.Fathername = LNameInput.Text;
            entry.Surname = SNameInput.Text;
            Helper.GetContext().Users.Add(entry);
            Helper.GetContext().SaveChanges();
            Close();
        }
    }
}