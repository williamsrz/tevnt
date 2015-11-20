using System;
using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore;
using TheEvnt.Services;

namespace TheEvnt.ViewModels
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            // Registering as singleton so that the data isn't recreated each time.
            Mvx.LazyConstructAndRegisterSingleton<IEventService, EventService>(); 
            Mvx.LazyConstructAndRegisterSingleton<ISessionService, SessionService>(); 
            Mvx.LazyConstructAndRegisterSingleton<ISpeakerService, SpeakerService>(); 
            Mvx.LazyConstructAndRegisterSingleton<ISponsorService, SponsorService>(); 
            Mvx.LazyConstructAndRegisterSingleton<ITrackService, TrackService>(); 


            RegisterAppStart<MainViewModel>();
        }
    }
}

