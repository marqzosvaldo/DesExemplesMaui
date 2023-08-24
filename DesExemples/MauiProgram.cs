using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;
using Sharpnado.Tabs;
using DesExemples.Views;
using DesExemples.ViewModels;

namespace DesExemples
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseSkiaSharp()
                .UseMauiCommunityToolkit()
                .UseSharpnadoTabs(loggerEnable: false)
                .ConfigureFonts(fonts =>
                {
                    //FlexaFonts
                    //Regular
                    fonts.AddFont("FlexaRegular4001000.ttf", "FlexaRegular");
                    fonts.AddFont("FlexaRegularExtended.ttf", "FlexaRegularExtended");
                    fonts.AddFont("FlexaRegularExpanded400150.ttf", "FlexaRegularExpanded");
                    // Medium
                    fonts.AddFont("FlexaMediumExtended.ttf", "FlexaMediumExtended");
                    fonts.AddFont("FlexaMedium.ttf", "FlexaMedium");
                    fonts.AddFont("FlexaMediumExpanded5001500.ttf", "FlexaMediumExpanded");

                    fonts.AddFont("FlexaMediumCompressed50050.ttf", "FlexaMediumCompressed");
                    fonts.AddFont("FlexaMediumXCompressed50000.ttf", "Flexa_Medium_X_Compressed");
                    fonts.AddFont("FlexaMediumCondensed50075.ttf", "FlexaMediumCondensed");


                    //FlexaVariableFont iOS
                    fonts.AddFont("GT-Flexa-GX.ttf", "GTFlexaVAR");
                    //FontAwesome
                    fonts.AddFont("FontAwesome5Regular.otf", "Font_Awesome_Regular");
                    fonts.AddFont("FontAwesome5Solid.otf", "Font_Awesome_Solid");
                    fonts.AddFont("FontAwesome5Brands.otf", "Font_Awesome_Brands");

                    fonts.AddFont("MaterialIconsOutlined-Regular.otf", "Material_IconsOR");


                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<MasterHomePage>();
            builder.Services.AddTransient<MasterHomeViewModel>();

            return builder.Build();
        }
    }
}