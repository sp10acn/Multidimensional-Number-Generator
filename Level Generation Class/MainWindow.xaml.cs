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

namespace Level_Generation_Class
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Generator g;

        public MainWindow()
        {
            InitializeComponent();
            g = new Generator();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            int[] result = g.GetSequence1D(20, 400, 1200);

            foreach (int i in result) {
                Console.Write(i + ", ");
            }
        }

        private void btnGenerate2D_Click(object sender, RoutedEventArgs e)
        {
            int[,] result = g.GetSequence2D(10, 10, 0, 10);

            for (int l = 0; l < result.GetLength(0); l++)
            {
                for (int w = 0; w < result.GetLength(1); w++)
                {
                    Console.Write(result[l,w] + ", ");
                }
                Console.WriteLine("");
            }
        }
    }
}
