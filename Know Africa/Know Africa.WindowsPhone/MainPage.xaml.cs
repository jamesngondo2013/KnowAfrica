using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Know_Africa
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            //BitmapImage bitmap = new BitmapImage();
            //itmap.UriSource = new Uri(this.BaseUri, "Images/Zimbabwe.png");

            //BitmapImage bitmap = new BitmapImage(new Uri("ms-appx:///Assets/Zimbabwe.png", UriKind.Absolute));
            imgFlag.Source = new BitmapImage(
                    new Uri(
                        "pack://application:,,,/Know Africa;component/Images/Zimbabwe.png"));
            
        }

        private void play_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Play));
        }

       
    }
}
