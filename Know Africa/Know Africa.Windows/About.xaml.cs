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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Know_Africa
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class About : Page
    {
        public About()
        {
            this.InitializeComponent();
            aboutUs();
        }

        private void back_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
                
        }
        public void aboutUs()
        {
            about.Text = "KNOW AFRICA-VERSION 1"+"\n"+
                "An easy-to-use app or game for learning by identifying different flags from"+"\n"+
                "different countries in Africa."+"\n"+
                "HOW TO PLAY"+"\n"+
                "Simply click/ tap the relevant flag as directed. There is a count down timer."+"\n"+ 
                "You will have to guess against the count down timer."+"\n"+ 
                "The score is accumulated as you progress."+"\n"+ 
                "This app is self-contained and does not require an internet connection. "+"\n"+
                "It is an excellent app for kids, individual students and even adults."+"\n"+
                "James Ngondo - Copyright 2014" + "\n" + 
                "jamesngondo2013@outlook.com ";

        }

    }
}
