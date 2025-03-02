## Freaky Controls are your usual Maui Controls but with a freaky twist to it :D

<div>
   <a href="https://www.nuget.org/packages/FreakyControls"><img src="https://img.shields.io/nuget/v/FreakyControls?color=blue&logo=nuget"></a>
   <a href="https://www.nuget.org/packages/FreakyControls"><img src="https://img.shields.io/nuget/dt/FreakyControls.svg"></a>
   <a href="./LICENSE"><img src="https://img.shields.io/github/license/freakyali/maui.freakycontrols"></a>
   <a href="https://www.codefactor.io/repository/github/freakyali/maui.freakycontrols"><img src="https://www.codefactor.io/repository/github/freakyali/maui.freakycontrols/badge"></a>
<a href="https://app.fossa.com/projects/git%2Bgithub.com%2FFreakyAli%2FMaui.FreakyControls?ref=badge_shield" alt="FOSSA Status"><img src="https://app.fossa.com/api/projects/git%2Bgithub.com%2FFreakyAli%2FMaui.FreakyControls.svg?type=shield"/></a>
</div>


## Platforms

| Support       | OS            |
| ------------- |:-------------:|
| iOS             | iOS 11.0 + |
| Android    | API 23+ (Marshmallow) | 


## Documentation
 
For more details and API documentation check our [Wiki](https://github.com/FreakyAli/MAUI.FreakyControls/wiki)

### Like what you saw? Want to keep this repo alive?
[![](https://miro.medium.com/max/600/0*wrBJU05A3BULKcWA.gif)](https://www.buymeacoffee.com/FreakyAli)

## Previews:

| iOS | Android |
| --- | --- |
| <img src="https://user-images.githubusercontent.com/31090457/195906310-ce95f402-7bea-4de2-93dd-f76f48683acf.gif" width="250" height="550"/>| <img src="https://user-images.githubusercontent.com/31090457/195906289-9a7dc44e-97ec-419c-807a-4aa63b739611.gif" width="250" height="550"/> |
| <img src="https://user-images.githubusercontent.com/31090457/195860576-1d5566ac-c4dc-41d0-9c1f-38338d9192c7.gif" width="250" height="550"/>| <img width="250" height="550" src="https://user-images.githubusercontent.com/31090457/195860338-d7286795-2c4a-4e7f-be91-0ff7f01a7747.gif" /> |
| <img src="https://user-images.githubusercontent.com/31090457/195864114-5a32df8c-32aa-4c42-850d-398a54babca3.gif" width="250" height="550"/>| <img width="250" height="550" src="https://user-images.githubusercontent.com/31090457/195864040-2f37c110-92b3-47af-af2a-b50d895a77b5.gif" /> |
| <img src="https://user-images.githubusercontent.com/31090457/195867103-37d65de1-6e39-42d9-9c98-705e49f4bc88.gif" width="250" height="550"/>| <img width="250" height="550" src="https://user-images.githubusercontent.com/31090457/195866605-20bf6373-53a3-44d9-9fde-c442ee1aec70.gif" /> |
| <img src="https://user-images.githubusercontent.com/31090457/210124414-9db3bf89-2079-4e45-8fb5-2f9ae6438e44.gif" width="250" height="550"/>| <img src="https://user-images.githubusercontent.com/31090457/210124403-a70fd95b-3668-4d5c-9973-e56aec4de514.gif" width="250" height="550"/> |
| <img src="https://user-images.githubusercontent.com/31090457/221354808-a022a9ea-2692-4a3b-b8a6-a9a9040ca855.gif" width="250" height="550"/>| <img src="https://user-images.githubusercontent.com/31090457/221354804-fdc55267-4e67-424c-a1ea-960517c8510c.gif" width="250" height="550"/>| 
| <img src="https://github.com/FreakyAli/Maui.FreakyControls/assets/31090457/45c38fc3-3f0b-4a75-86ad-e9a52a64095c" width="250" height="550"/>| <img src="https://github.com/FreakyAli/Maui.FreakyControls/assets/31090457/0c5a1192-a3db-4f10-bb2c-0e29eeff73de" width="250" height="550"/>| 


## License 

The license for this project can be found [here](https://github.com/FreakyAli/Maui.FreakyControls/blob/master/LICENSE)



## Installation

Add our [NuGet](https://www.nuget.org/packages/FreakyControls) package or 

Run the following command to add our Nuget to your .Net MAUI app:

      Install-Package FreakyControls -Version xx.xx.xx

**Adding FreakyControlsHandlers to your MAUI app**:

Add the following using statement and then Init the handlers in your MauiProgram: 

      using MAUI.FreakyControls.Extensions;
      
### For Version 4.3 and below:   
      
      namespace Something;
      
      public static class MauiProgram
      {     
      var builder = MauiApp.CreateBuilder();
		  builder
			.UseMauiApp<App>()
      .ConfigureMauiHandlers(handlers =>
      {
          handlers.AddFreakyHandlers(); // To Init your freaky handlers for Entry and Editor
      });
                  // This line is needed for the following issue: https://github.com/mono/SkiaSharp/issues/1979
		  builder.InitSkiaSharp(); // Use this if you want to use FreakySvgImageView 
		  return builder.Build();
      } 

### Post version 4.3:

   namespace Samples;

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
	    //Initialization is now a one-liner and the old methods have been deprecated and will be removed in future updates.
        //Takes one argument if you would like to init Skiasharp through FreakyControls or not (Used for RadioButton, Checkbox & SVGImageView)
             builder.InitializeFreakyControls();
             return builder.Build();
         }
      }
Now you can use the controls in your app.

## Activity 

Fossa: 

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2FFreakyAli%2FMaui.FreakyControls.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2FFreakyAli%2FMaui.FreakyControls?ref=badge_large)

Sparkline: 

[![Sparkline](https://stars.medv.io/FreakyAli/Maui.FreakyControls.svg)](https://stars.medv.io/FreakyAli/Maui.FreakyControls)

RepoBeats:

![RepoBeats](https://repobeats.axiom.co/api/embed/37b730ec7020123a37b048636c0babfac3b4a014.svg "Repobeats analytics image")
