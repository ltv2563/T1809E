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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MusicILike.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MyFrame = this.Frame;
            if (Login.IsSelected) { Frame.Navigate(typeof(Pages.Login), Login); }
            else if (Register.IsSelected) { Frame.Navigate(typeof(Pages.Signup)); }
            else if (Registersong.IsSelected) { Frame.Navigate(typeof(Pages.RegisterSong)); }
            else if (ListSong.IsSelected) { Frame.Navigate(typeof(Pages.ListSong)); }

        }
    }
}
