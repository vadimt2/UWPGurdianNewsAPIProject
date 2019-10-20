using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace UWPGurdianPROJ.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public IMvxCommand GoToContentPageCommand { get; private set; }
        public IMvxCommand GoToSectionPageCommand { get; private set; }

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Prepare()
        {
            GoToContentPageCommand = new MvxCommand(() => {
                _navigationService.Navigate<ContentViewModel>();
            });

            GoToSectionPageCommand = new MvxCommand<string>(pram => {
                _navigationService.Navigate<SectionViewModel, string>(pram);
            });
            base.Prepare(); 
        }
    }
}
