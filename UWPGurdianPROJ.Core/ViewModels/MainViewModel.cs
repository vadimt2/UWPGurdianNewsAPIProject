using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UWPGurdianPROJ.Core.Services;

namespace UWPGurdianPROJ.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        private readonly IPrecincy _precincy;


        private string _selectedItemProp;
        public string SelectedItemProp
        {
            get => _selectedItemProp; set
            {
                SetProperty(ref _selectedItemProp, value);
            }
        }

        public IMvxCommand GoToContentPageCommand { get; private set; }
        public IMvxCommand GoToSectionPageCommand { get; private set; }

        public MainViewModel(IMvxNavigationService navigationService, IPrecincy precincy)
        {
            _navigationService = navigationService;

            _precincy = precincy;
        }

        public override void Prepare()
        {
           
            GoToSectionPageCommand = new MvxCommand<string>(pram =>
            {
                _navigationService.Navigate<SectionViewModel, string>(pram);
            });
            base.Prepare();
        }

       
        public override void ViewAppeared()
        {
            if (SelectedItemProp != null)
                _navigationService.Navigate<SectionViewModel, string>(SelectedItemProp);
            base.ViewAppeared();
        }
    }
}
