using Microsoft.Extensions.Logging;

namespace BisnisJamanNow
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
                    fonts.AddFont("Poppins-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("Poppins-SemiBold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Poppins-Bold.ttf", "OpenSansbold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageVM>();
            return builder.Build();
        }
    }
}