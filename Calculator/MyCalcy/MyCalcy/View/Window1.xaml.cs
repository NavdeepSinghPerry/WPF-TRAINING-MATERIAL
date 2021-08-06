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

namespace MyCalcy.View
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show((e.OriginalSource as Button).Name.ToString());
        }

        public void GetString()
        {
            
        }

        public void ShowString(Action action)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ShowString(() => new StartUpWindow());
        }
    }
}
