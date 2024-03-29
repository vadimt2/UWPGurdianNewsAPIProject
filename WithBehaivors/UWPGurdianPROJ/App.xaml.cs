﻿using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;

namespace UWPGurdianPROJ
{
    sealed partial class App : UWPApplication
    {
        public App()
        {
            InitializeComponent();
        }
    }

    public abstract class UWPApplication :
        MvxApplication<MvxWindowsSetup<Core.App>, Core.App>
    {
    }
}