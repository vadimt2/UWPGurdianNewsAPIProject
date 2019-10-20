using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using UWPGurdianPROJ.Core.ViewModels;

namespace UWPGurdianPROJ.Core.Models
{
    public class GRNAppContext : MvxNotifyPropertyChanged, IGRNAppContext
    {
        //private ReadOnlyObservableCollection<StoryHeader> _storyHeaders;

        private ObservableCollection<StoryHeader> _innerStoryHeaders;
        public ObservableCollection<StoryHeader> InnerStoryHeaders
        {
            get => _innerStoryHeaders;
            set
            {
                SetProperty(ref _innerStoryHeaders, value);
            }
        }


        public GRNAppContext()
        {
            //_innerStoryHeaders = new ObservableCollection<StoryHeader>();

            //_storyHeaders = new ReadOnlyObservableCollection<StoryHeader>(_innerStoryHeaders);
        }
    }
}
