using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPGurdianPROJ.Core.Models;

namespace UWPGurdianPROJ.Core.ViewModels
{
    public class ContentViewModel : MvxViewModel
    {
        private readonly IGRNAppContext _context;

        private readonly IMvxNavigationService _mvxNavigationService;

        private Dictionary<string, string> _setUp;

        private readonly IHttpService _httpService;

        private ObservableCollection<StoryHeader>_articals;

        public IMvxCommand GoTOConetentCommand { get; private set; }

        public ObservableCollection<StoryHeader> Articals { get => _articals; set {
                SetProperty(ref _articals, value);
            } }
        public ContentViewModel(IGRNAppContext context, IHttpService httpService, IMvxNavigationService mvxNavigationService)
        {
            _context = context;
            _httpService = httpService;
            _mvxNavigationService = mvxNavigationService;

        }

        public override void Prepare()
        {
            _context.InnerStoryHeaders = new ObservableCollection<StoryHeader>();
            _setUp = new Dictionary<string, string>();
            _setUp.Add(Constants.API_KEY_PARAM, Constants.API_KEY);
            _setUp.Add(Constants.SHOW_FIELDS_PARAM, "headline,trailText,thumbnail,published,contributor,last-modified");
            _setUp.Add(Constants.PAGE_SIZE_PARAM, "10"); // ArticleNumber
            _setUp.Add(Constants.PAGE_PARAM, "1"); // PageNumber
            Task t = Load(_setUp);
            GoTOConetentCommand = new MvxCommand<StoryHeader>(item => {
                var a = item;
                _mvxNavigationService.Navigate<WebItemViewModel,string>(item.WebUrl);
            });
            base.Prepare();
        }


        private async Task Load(Dictionary<string, string> setUp)
        {
            var getContent = await _httpService.GetAsync<SearchResult>($"{Constants.BASE_API_URL}search", setUp);
            for (int i = 0; i < getContent.SearchResponse.StoryHeaders.Length; i++)
                _context.InnerStoryHeaders.Add(getContent.SearchResponse.StoryHeaders[i]);
            Articals = _context.InnerStoryHeaders;
        }
    }
}
