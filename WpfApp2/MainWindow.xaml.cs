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

namespace WpfApp2
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

        private void TestBTN_Click(object sender, RoutedEventArgs e)
        {
            Button btn = new Button();
            btn.Content = "Press me";
            btn.Width = 75;
            btn.Height = 50;
            btn.Margin = new Thickness(100, 50, 0, 0); // расположение элемента в контейнере задается с помощью свойства Margin и объекта Thickness
            btn.HorizontalAlignment = HorizontalAlignment.Left;
            btn.VerticalAlignment = VerticalAlignment.Top;
            rootwindow.Children.Add(btn);
        }
    }
}
