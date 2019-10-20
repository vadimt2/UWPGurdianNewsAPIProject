using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using MvvmCross.ViewModels;
using UWPGurdianPROJ.Core.ViewModels;
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

namespace UWPGurdianPROJ.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainView
    {
        MainViewModel MainViewModel => (ViewModel as MainViewModel);

        public MainView()
        {
            this.InitializeComponent();
        }

        private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            switch ((args.InvokedItem) as string)
            {
                case "Home":
                    MainViewModel.GoToContentPageCommand.Execute();
                    break;
                case "Sport":
                    MainViewModel.GoToSectionPageCommand.Execute("sport");
                    break;
                case "Politics":
                    MainViewModel.GoToSectionPageCommand.Execute("politics");
                    break;
                case "Environment":
                    MainViewModel.GoToSectionPageCommand.Execute("environment");
                    break;
                default:
                    break;
            }
        }

        

    }
}
