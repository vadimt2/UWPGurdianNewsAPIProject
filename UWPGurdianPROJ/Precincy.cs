using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPGurdianPROJ.Core.Services;
using Windows.Storage;
using Windows.UI.Xaml;

namespace UWPGurdianPROJ
{
    public class Precincy : IPrecincy
    {
        
        public void SaveLastData(string lastPage)
        {
            if (lastPage == null) return;

            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            localSettings.Values["LastPage"] = lastPage;
        }
        public string LoadLastData()
        {
            
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            var savedData = localSettings.Values["LastPage"] as string;
            return savedData ?? savedData;
        }



    }
}
