using FranceVacances.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FranceVacances
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().SetDesiredBoundsMode(ApplicationViewBoundsMode.UseCoreWindow); //content under appbar

            


        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            EmbeddedFrame.Navigate(typeof(Home), null);
        }



        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NavButton_Click(object sender, RoutedEventArgs e)
        {
            Button but = new Button();
            but = sender as Button;

            switch (but.Name.ToString())
            {
                default:
                    break;

                case "Forward":
                    if (EmbeddedFrame.CanGoForward)
                    {
                        EmbeddedFrame.GoForward();
                    }

                    break;
                case "Back":
                    if (EmbeddedFrame.CanGoBack)
                    {
                        EmbeddedFrame.GoBack();
                    }
                    break;

                case "Home":
                    EmbeddedFrame.Navigate(typeof(Home), null);
                    break;

                case "AppBar":
                        if (!this.TopAppBar.IsOpen)
                    {
                        this.TopAppBar.IsOpen = true;
                    }
                    else
                    {
                        this.TopAppBar.IsOpen = false;
                    }
                    break;
            }
        }

    }
}
