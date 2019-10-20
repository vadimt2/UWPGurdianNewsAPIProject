using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using UWPGurdianPROJ.Core.ViewModels;

namespace UWPGurdianPROJ.Core.Models
{
    public interface IGRNAppContext
    {
        ObservableCollection<StoryHeader> InnerStoryHeaders { get; set; }

        Task Load(Dictionary<string, string> setUp, string section);
    }
}