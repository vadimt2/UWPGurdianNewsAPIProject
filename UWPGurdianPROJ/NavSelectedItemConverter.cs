using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPGurdianPROJ.Core.ViewModels;
using Windows.UI.Xaml.Data;

namespace UWPGurdianPROJ
{
    public class NavSelectedItemConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {

            var item = value as string;

            var test = Char.ToUpperInvariant(Constants.MainHome[0]) + Constants.MainHome.Substring(1);

            if (item == null) return  Char.ToUpperInvariant(Constants.MainHome[0]) + Constants.MainHome.Substring(1);

           return Char.ToUpperInvariant(item[0]) + item.Substring(1);

        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
