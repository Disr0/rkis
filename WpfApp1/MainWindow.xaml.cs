using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Microsoft.EntityFrameworkCore;
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            if (UsersPlusGrid.Visibility == Visibility.Visible)
            {
                UsersPlusGrid.ItemsSource = Helper.GetContext().Users.Include(u => u.RoleNavigation).ToList();
            }
            else
            {
                UsersDataGrid.ItemsSource = Helper.GetContext().Users.ToList();
            }
        }

        private User? GetDataGridSelectedItem()
        {
            User? SelectedItem;
            if (UsersPlusGrid.Visibility == Visibility.Visible)
            {
                SelectedItem = UsersPlusGrid.SelectedValue as User;
            }
            else
            {
                SelectedItem = UsersDataGrid.SelectedValue as User;
            }

            return SelectedItem;
        }
        private void DeleteSelected_Click(object sender, RoutedEventArgs e)
        {
            User? SelectedItem = GetDataGridSelectedItem();
            if (SelectedItem != null)
            {
                User userValue = SelectedItem;
                Helper.GetContext().Users.Remove(userValue);
                Helper.GetContext().SaveChanges();
                LoadData();
            }
        }
        private void UpdateSelected_Click(object sender, RoutedEventArgs e)
        {
            User? SelectedItem = GetDataGridSelectedItem();

            if (SelectedItem != null)
            {
                Helper.GetContext().Update(SelectedItem);
                Helper.GetContext().SaveChanges();
                LoadData();
            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            var register = new Register();
            register.ShowDialog();
            LoadData();
        }

        private void Find_Click(object sender, RoutedEventArgs e)
        {
            var search = new SearchQuery();
            search.ShowDialog();
        }
    }
}