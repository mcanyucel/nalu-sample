using Microsoft.Extensions.Logging;
using Nalu;

namespace nalu_sample
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseNaluNavigation<App>(RegisterPages)
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        private static void RegisterPages(NavigationConfigurator configurator)
        {
            configurator.AddPage<MainPageViewModel, MainPage>();
            configurator.AddPage<NewPage1ViewModel, NewPage1>();
            configurator.AddPage<NewPage2ViewModel, NewPage2>();
        }
    }
}
