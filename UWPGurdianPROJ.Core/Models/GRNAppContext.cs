using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using UWPGurdianPROJ.Core.ViewModels;

namespace UWPGurdianPROJ.Core.Models
{
    public class GRNAppContext : MvxNotifyPropertyChanged, IGRNAppContext
    {
        //private ReadOnlyObservableCollection<StoryHeader> _storyHeaders;

        private readonly IHttpService _httpService;

        public GRNAppContext(IHttpService httpService )
        {
            _httpService = httpService;
            InnerStoryHeaders = new ObservableCollection<StoryHeader>();
        }

        private ObservableCollection<StoryHeader> _innerStoryHeaders;
        public ObservableCollection<StoryHeader> InnerStoryHeaders
        {
            get => _innerStoryHeaders;
            set
            {
                SetProperty(ref _innerStoryHeaders, value);
            }
        }


        public async Task Load(Dictionary<string, string> setUp, string section)
        {
            var getContent = await _httpService.GetAsync<SearchResult>($"{Constants.BASE_API_URL}{section}", setUp);
            for (int i = 0; i < getContent.SearchResponse.StoryHeaders.Length; i++)
                InnerStoryHeaders.Add(getContent.SearchResponse.StoryHeaders[i]);
        }

    }
}
