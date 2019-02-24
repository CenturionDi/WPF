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

namespace WpfTriple
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int index = 0;
        //public User Leha = new User
        //{
        //    login = "Leha",
        //    password = "1"
        //};
        //public User Ivan = new User
        //{
        //    login = "Ivan",
        //    password = "12"
        //};
        //public User Oleg = new User
        //{
        //    login = "Oleg",
        //    password = "123"
        //};
        Users users= new Users();
        public MainWindow()
        {

            InitializeComponent();
            //users.Add(Leha);
            //users.Add(Ivan);
            //users.Add(Oleg);
        }
        private void Move_mouse(object sender, MouseEventArgs e)
        {
            var h = (int)((System.Windows.Controls.Panel)Application.Current.MainWindow.Content).ActualHeight;
            var w = (int)((System.Windows.Controls.Panel)Application.Current.MainWindow.Content).ActualWidth;

            var bw = (int)Catch.Width;
            var bh = (int)Catch.Height;
            Random rand = new Random();
            Catch.Margin = new Thickness(rand.Next(0, w - bw), rand.Next(0, h - bh), 0, 0);

        }

        private void CopyClick(object sender, RoutedEventArgs e)
        {
            RichText.Copy();
        }
        private void CutClick(object sender, RoutedEventArgs e)
        {
            RichText.Cut();
        }
        private void PasteClick(object sender, RoutedEventArgs e)
        {
            RichText.Paste();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                
                string tempLogin = log.Text;
                string tempPassword = pass.Text;
            for (int i = 0; i < users.users.Count; i++)
            {
                if ((users.users[i].login == tempLogin) && (users.users[i].password == tempPassword))
                {
                    //Window Window1 = new Window();
                    //Window1.Show();
                    users.currentId = i;
                    Window1 win2 = new Window1(this);
                    win2.Show();
                    //win2.DataContext = this;


                }
            }
        }
    }
}
