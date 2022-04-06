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

namespace SLAU_Kramer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double[,] a = new double[3, 3];
        double[] b = new double[3];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            a[0, 0] = double.Parse(A01.Text);
            a[0, 1] = double.Parse(A02.Text);
            a[0, 2] = double.Parse(A03.Text);

            a[1, 0] = double.Parse(A11.Text);
            a[1, 1] = double.Parse(A12.Text);
            a[1, 2] = double.Parse(A13.Text);

            a[2, 0] = double.Parse(A21.Text);
            a[2, 1] = double.Parse(A22.Text);
            a[2, 2] = double.Parse(A23.Text);

            b[0] = double.Parse(B0.Text);
            b[1] = double.Parse(B1.Text);
            b[2] = double.Parse(B2.Text);

            Kramer kramer = new Kramer();
            kramer.GetNums(a,b);

            X.Text = Convert.ToString(a[0,1]);
        }
    }
}
