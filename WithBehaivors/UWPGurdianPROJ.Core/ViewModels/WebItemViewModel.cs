using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace UWPGurdianPROJ.Core.ViewModels
{
    public class WebItemViewModel : MvxViewModel<string>
    {
        private string _sourceString;
        public string SourceString { get => _sourceString; set {
                SetProperty(ref _sourceString, value);
            } }

        public override void Prepare(string parameter)
        {
            SourceString = parameter;
        }
    }
}
