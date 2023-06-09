using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WpfApp1.Models;

namespace WpfApp1;

public partial class SearchQuery : Window
{
    public SearchQuery()
    {
        InitializeComponent();
    }

    public void Search_Click(object sender, RoutedEventArgs e)
    {
        List<User> result = Helper.GetContext().Users.ToList();
        List<string> list = new List<string>
        {
            SNameInput.Text,
            FNameInput.Text,
            LNameInput.Text,
            LoginInput.Text,
            RoleChooser.Text
        };
        if (SNameInput.Text != "")
        {
            result = result.Where(i => i.Surname == SNameInput.Text).ToList();
        }
        if (FNameInput.Text != "")
        {
            result = result.Where(i => i.Name == FNameInput.Text).ToList();
        }
        if (LNameInput.Text != "")
        {
            result = result.Where(i => i.Fathername == LNameInput.Text).ToList();
        }
        if (LoginInput.Text != "")
        {
            result = result.Where(i => i.Login == LoginInput.Text).ToList();
        }

        if (RoleChooser.Text != "")
        {
            int role;
            if (RoleChooser.Text == "Админ")
            {
                role = 2;
            }
            else
            {
                role = 1;
            }
            result = result.Where(i => i.Role == role).ToList();
        }

        var searchResult = new SearchResult();
        if (Helper.isAdmin)
        {
            searchResult.UsersDataGrid.Visibility = Visibility.Hidden;
            searchResult.UsersPlusGrid.ItemsSource = result;
        }
        else
        {
            searchResult.UsersPlusGrid.Visibility = Visibility.Hidden;
            searchResult.UsersDataGrid.ItemsSource = result;
        }
        searchResult.Show();
        Close();
    }
}