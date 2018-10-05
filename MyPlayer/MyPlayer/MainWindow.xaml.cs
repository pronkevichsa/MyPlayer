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

namespace MyPlayer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var player = new Player();
            //player._volume = 300;
            //textBox.Text = player._volume.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void slider_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            textBox.Text = slider.Value.ToString();
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            textBox.Text = slider.Value.ToString();
        }
    }
}
