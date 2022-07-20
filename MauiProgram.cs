﻿using Microsoft.AspNetCore.Components.WebView.Maui;
using Blazorise;
using Blazorise.Bootstrap;

namespace Teste;

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
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();

		builder.Services.AddBlazorise(options =>
		{
			options.Immediate = true;
		});

		builder.Services.AddBootstrapProviders();
#endif

        return builder.Build();
	}
}
