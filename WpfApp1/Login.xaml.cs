using System;
using System.Linq;
using System.Net.Mime;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using WpfApp1.Models;

namespace WpfApp1;

public partial class Login : Window
{
    public Login()
    {
        InitializeComponent();
    }

    public void OnLoginClick(object sender, RoutedEventArgs e)
    {
        try
        {
            var first = Helper.GetContext().Users.First(u => u.Login == LoginBox.Text && u.Password == PasswordBox.Text);
            Console.WriteLine(first);
            MainWindow window = new MainWindow();
            if (first.Role == 1)
            {
                window.UsersPlusGrid.Visibility = Visibility.Hidden;
                Helper.isAdmin = false;
            }
            else
            {
                window.UsersDataGrid.Visibility = Visibility.Hidden;
                Helper.isAdmin = true;
            }
            window.LoadData();
            window.Show();
        }
        catch (Exception)
        {
            MessageBox.Show("Неправильно введён пароль или логин");
        }
        Close();
    }

    private void ButtonRegisterClick(object sender, RoutedEventArgs e)
    {
        Register window = new Register();
        window.Owner = this;
        window.ShowDialog();
    }
}