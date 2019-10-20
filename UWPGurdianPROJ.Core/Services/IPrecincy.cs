using System;
using System.Collections.Generic;
using System.Text;

namespace UWPGurdianPROJ.Core.Services
{
    public interface IPrecincy
    {
        void SaveLastData(string lastPage);

        string LoadLastData();
    }
}
