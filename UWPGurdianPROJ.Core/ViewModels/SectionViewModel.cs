using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using UWPGurdianPROJ.Core.Models;
using UWPGurdianPROJ.Core.Services;

namespace UWPGurdianPROJ.Core.ViewModels
{
    public class SectionViewModel : MvxViewModel<string>
    {
        private readonly IGRNAppContext _context;

        private readonly IMvxNavigationService _mvxNavigationService;

        private readonly IPrecincy _precincy;


        private Dictionary<string, string> _setUp;

        public IMvxCommand GoTOConetentCommand { get; private set; }


        private string _section;

        public ObservableCollection<StoryHeader> Articals  { get => _context.InnerStoryHeaders; }

        public SectionViewModel(IGRNAppContext context, IMvxNavigationService mvxNavigationService, IPrecincy precincy)
        {
            _context = context;

            _context.InnerStoryHeaders = new ObservableCollection<StoryHeader>();

            _mvxNavigationService = mvxNavigationService;

            _precincy = precincy;

        }

        public override void Prepare(string parameter)
        {
            _section = parameter;
            _setUp = new Dictionary<string, string>();
            _setUp.Add(Constants.API_KEY_PARAM, Constants.API_KEY);
            _setUp.Add(Constants.SHOW_FIELDS_PARAM, "trailText,thumbnail");
            _setUp.Add(Constants.PAGE_SIZE_PARAM, "10"); // ArticleNumber
            _setUp.Add(Constants.PAGE_PARAM, "1"); // PageNumber
            GoTOConetentCommand = new MvxCommand<StoryHeader>(item =>
            {
                var a = item;
                _mvxNavigationService.Navigate<WebItemViewModel,string>(item.WebUrl);
            });
        }

        public async override Task Initialize()
        {
            await _context.Load(_setUp, _section);
            _precincy.SaveLastData(_section);
        }
    }
}
