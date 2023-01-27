using TestErrorApplyQueryAttributes.MVVM.ViewModels;
using TestErrorApplyQueryAttributes.MVVM.Views;

namespace TestErrorApplyQueryAttributes;

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

        builder.Services.AddTransient<Page1View>();
        builder.Services.AddTransient<Page1ViewModel>();

        builder.Services.AddTransient<Page2View>();
        builder.Services.AddTransient<Page2ViewModel>();

        builder.Services.AddTransient<SecondLevelPageView>();
        builder.Services.AddTransient<SecondLevelPageViewModel>(); 

        return builder.Build();
	}
}
