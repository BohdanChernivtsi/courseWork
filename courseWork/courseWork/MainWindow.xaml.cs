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

namespace courseWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected void LoadDBAndChangeWindow()
        {
            DBConnection dBConnection = DBConnection.getInstance();
            Window1 w = new Window1();
            w.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadDBAndChangeWindow();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LoadDBAndChangeWindow();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
