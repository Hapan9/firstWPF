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

namespace firstWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            label1.ItemsSource = BLL.UserBase.allUsers;
            label2.ItemsSource = BLL.Library.allBooks;
        }

        private void label1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Models.User user = (Models.User)label1.SelectedItem;
            MessageBox.Show(user.AllInfo());
        }

        private void label2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
