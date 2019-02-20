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
            RGB_to_XYZ();
            InitializeComponent();

        }

        private byte R = 200, G=200, B=100;
        private double X = 0, Y = 0, Z = 0;
        private void Rect_Change()// byte R, byte G, byte B)
        {
            MRectangle.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));
            XSlider.Value = this.X;
            YSlider.Value = this.Y;
            ZSlider.Value = this.Z;
        }

        private void RGB_to_XYZ()
        {
            double r = this.R / 255;
            double g = this.G / 255;
            double b = this.B / 255;
            if (r > 0.04045)
                r = Math.Pow(((r + 0.055) / 1.055), 2.4);
            else
                r = r / 12.92;
            if (g > 0.04045)
                g = Math.Pow(((g + 0.055) / 1.055), 2.4);
            else
                g = g / 12.92;
            if (b > 0.04045)
                b = Math.Pow(((b + 0.055) / 1.055), 2.4);
            else
                b = b / 12.92;
            r *= 100;
            g *= 100;
            b *= 100;
            this.X = r * 0.4124 + g * 0.3576 + b * 0.1805;
            this.Y = r * 0.2126 + g * 0.7152 + b * 0.0722;
            this.Z = r * 0.0193 + g * 0.1192 + b * 0.9505;

        }

        private void YSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
        

        /// <summary>
        /// RGB event functionality
        /// </summary>
        /// <param name="sender"> Event host </param> 
        /// <param name="e">changed detector</param>
        private void SliderR_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            byte r = (byte)slider.Value;
            this.R = r;
            RGB_to_XYZ();
            Rect_Change();
        }

        private void SliderG_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            byte g = (byte)slider.Value;
            this.G = g;
            RGB_to_XYZ();
            Rect_Change();
        }

        private void SliderB_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            byte b = (byte)slider.Value;
            this.B = b;
            RGB_to_XYZ();
            Rect_Change();

        }
        private void XSlider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
