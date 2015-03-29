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

namespace Domaći1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            this.DodajL.Click += DodajL_Click;
            this.DodajR.Click += DodajR_Click;
        }

        void DodajR_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();

            Rectangle rectangle = new Rectangle();

            rectangle.Height = 30;
            rectangle.Width = 350;
            rectangle.Fill = Brushes.Red;
            rectangle.Margin = new Thickness(5);

            this.RRectangleContainer.Children.Add(rectangle);
        }

        void DodajL_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();

            Rectangle rectangle = new Rectangle();

            rectangle.Height = 60;
            rectangle.Width = 60;
            rectangle.Fill = Brushes.Orange;
            rectangle.Margin = new Thickness(5);

            this.LRectangleContainer.Children.Add(rectangle);
        }
    }
}
