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

namespace RubberDucky
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            this.WindowStyle = WindowStyle.None;
            this.Title = "Ducky";
            this.Width = 200;
            this.Height = 200;
            this.Topmost = true;
            this.ResizeMode = ResizeMode.NoResize; 
            this.ShowInTaskbar = false;

            Image myImage = new Image();
            myImage.Width = 200;

           
            BitmapImage myBitmapImage = new BitmapImage();

         
            myBitmapImage.BeginInit();
            myBitmapImage.UriSource = new Uri("Image/ducky.png", UriKind.RelativeOrAbsolute);



            myBitmapImage.DecodePixelWidth = 200;
            myBitmapImage.EndInit();

            myImage.Source = myBitmapImage;

            this.Content = myImage;

          
           
         
            this.Closed += (sender, e) => Application.Current.Shutdown();

        
            this.Left = SystemParameters.WorkArea.Width - this.Width;
            this.Top = SystemParameters.WorkArea.Height - this.Height;

            

        }

       
    }
}
