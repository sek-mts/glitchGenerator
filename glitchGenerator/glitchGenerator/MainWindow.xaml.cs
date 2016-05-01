using glitchGenerator.ViewModel;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace glitchGenerator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnLoadImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
                try
                {
                    ChangePixels cP = new ChangePixels();
                    Bitmap bmp = null;
                    bmp = (Bitmap)Image.FromFile(ofd.FileName);
                    bmp = cP.ChangeColor(bmp);
                    //bmp.Save(@"<your path>");
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }


        }
    }
}
