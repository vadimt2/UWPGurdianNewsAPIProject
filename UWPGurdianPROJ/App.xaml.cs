using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;
using UWPGurdianPROJ.Core.Services;

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
        MvxApplication<SetupUwpApp, Core.App>
    {
    }

    public class SetupUwpApp : MvxWindowsSetup<Core.App>
    {
        // They will know each other
        protected override void InitializeFirstChance()
        {
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IPrecincy, Precincy>();

            base.InitializeFirstChance();
        }
    }
}