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

namespace WpfTriple
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    //public partial class Window1 : MainWindow
    public partial class Window1 : Window
    {
        int id;

        public Window1(MainWindow mainWindow)
        {
            InitializeComponent();
            id = mainWindow.index;
            if (users.users[id].choice=="Green")
            {
                window2.Background = Brushes.Green;
            }
            else if (users.users[id].choice == "Yellow")
            {
                window2.Background = Brushes.Yellow;
            }
            else if (users.users[id].choice == "Red")
            {
                window2.Background = Brushes.Red;
            }

        }
        Users users = new Users();

      

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            
            users.users[id].choice = (string)Green.Content;
            window2.Background = Brushes.Green;
        }
        
        private void Yellow_Click(object sender, RoutedEventArgs e)
        {
           
            users.users[id].choice = (string)Yellow.Content;
            window2.Background = Brushes.Yellow;
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            users.users[id].choice = (string)Yellow.Content;
            window2.Background = Brushes.Red;
        }
    }
}
