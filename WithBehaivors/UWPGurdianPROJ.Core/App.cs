using UWPGurdianPROJ.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using UWPGurdianPROJ.Core.Models;
using MvvmCross;

namespace UWPGurdianPROJ.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IGRNAppContext, GRNAppContext>();
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IHttpService, HttpService>();


            RegisterAppStart<MainViewModel>();


        }
    }
}
