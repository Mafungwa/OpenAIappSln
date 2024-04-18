using Microsoft.Extensions.Logging;
using OpenAIapp.Services;
using OpenAIapp.ViewModels;
using OpenAIapp.Views;
using OpenAIapp;

namespace OpenAIapp
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

            builder.Services.AddTransient<DisplayView>();

            OpenAIService svc = new OpenAIService();
            svc.Initialize(OpenAIapp.Constants.OpenAIKey, Constants.OpenAIEndpoint);
            builder.Services.AddSingleton<OpenAIService>(svc);


            builder
                .RegisterViewModels()
                .RegisterViews();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<DisplayViewModel>();
           // mauiAppBuilder.Services.AddSingleton<LoadsheddingAnswerViewModel>();

            // More view-models registered here.

            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<DisplayView>();
           // mauiAppBuilder.Services.AddSingleton<LoadsheddingAnswerPage>();

            // More views registered here.

            return mauiAppBuilder;
        }


    }
}
