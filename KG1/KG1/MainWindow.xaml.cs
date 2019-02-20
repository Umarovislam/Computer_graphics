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

namespace KG1
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

        private void Reqt_Change(object sender, int R, int G, int B)
        {

        }

        private void SliderR_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            throw new NotImplementedException();
            var slider = sender as Slider;
        //    MRectangle.Fill = new SolidColorBrush(Color.FromRgb())
        }

        private void XSlider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            throw new NotImplementedException();
        }

        private void SliderG_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            throw new NotImplementedException();
        }

        private void SliderB_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            throw new NotImplementedException();
        }
    }
}
