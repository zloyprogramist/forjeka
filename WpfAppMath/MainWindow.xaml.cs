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
using static System.Int32;

namespace WpfAppMath
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
        
        private readonly int _a1;
        private readonly int _a2;
        private readonly int _a3;
        private readonly int _a4;
        private readonly int _b1;
        private readonly int _b2;
        private readonly int _b3;


        
        private void Calculate(object sender, RoutedEventArgs e)
        {
            var n = TextBox.Text;
            TryParse(n, out var n1);
            var result = (((_b1 - _a1) * _a2 * _a3 * _a4) / (_b1 * (_b1 + 1) * _b2 * _b3)) * n1;
            TextBlockAnswer.Text = result.ToString();
        }
    }
}