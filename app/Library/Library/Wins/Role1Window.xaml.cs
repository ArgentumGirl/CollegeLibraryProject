using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace Library.Wins
{
    /// <summary>
    /// Логика взаимодействия для Role1Window.xaml
    /// </summary>
    public partial class Role1Window : Window
    {
        public Role1Window()
        {
            InitializeComponent();
        }

        private void ButtonLogOut_Click(object sender, RoutedEventArgs e)
        {
            Authorization authwin = new Authorization();
            authwin.Show();
            this.Close();
        }
    }
}
