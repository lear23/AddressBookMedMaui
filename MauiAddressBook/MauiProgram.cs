using MauiAddressBook.ViewsModels;
using Microsoft.Extensions.Logging;
using SharedLibrary.Services;

namespace MauiAddressBook
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                });

            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<MainPage>();
            // I Startup.cs eller motsvarande fil
            builder.Services.AddSingleton<CustomerService>();



            builder.Logging.AddDebug();
            return builder.Build();
        }
    }
}
