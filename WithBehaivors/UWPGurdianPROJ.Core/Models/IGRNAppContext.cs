using System.Collections.ObjectModel;
using UWPGurdianPROJ.Core.ViewModels;

namespace UWPGurdianPROJ.Core.Models
{
    public interface IGRNAppContext
    {
        ObservableCollection<StoryHeader> InnerStoryHeaders { get; set; }
    }
}