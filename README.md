# AutoCompleteSample
 An iOS and Android app built in Xamarin.Forms, demontstrating the the [Syncfusion.Xamarin.SfAutoComplete NuGet Package](https://www.nuget.org/packages/Syncfusion.Xamarin.SfAutoComplete).

> **Note**: Syncfusion can be used for Free via its [Community License](https://www.syncfusion.com/products/communitylicense).

![](https://i.stack.imgur.com/hVf2V.gif)

# Walkthrough

### 1. Install Syncfusion.Xamarin.SfAutoComplete NuGet Package

1. In Visual Studio, add the [Syncfusion.Xamarin.SfAutoComplete NuGet Package](https://www.nuget.org/packages/Syncfusion.Xamarin.SfAutoComplete) to your iOS project, Android project and .NET Standard Project (if applicable).

### 2. Initialize Syncfusion.Xamarin.SfAutoComplete on iOS

1. In the iOS Project, open `AppDelegate.cs`
2. In the `AppDelegate.cs` file, in `AppDelegate.FinishedLaunching` method, add `new Syncfusion.SfAutoComplete.XForms.iOS.SfAutoCompleteRenderer();`, like so:

```csharp
[Register(nameof(AppDelegate))]
public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
{
    public override bool FinishedLaunching(UIApplication app, NSDictionary options)
    {
        new Syncfusion.SfAutoComplete.XForms.iOS.SfAutoCompleteRenderer();

        global::Xamarin.Forms.Forms.Init();
        LoadApplication(new App());

        return base.FinishedLaunching(app, options);
    }
}
```

## 3. Use Syncfusion.Xamarin.SfAutoComplete in Xamarin.Forms

Here is an example of a Xamarin.Forms app using Syncfusion.Xamarin.SfAutoComplete:

```csharp
using System.Collections.Generic;
using Syncfusion.SfAutoComplete.XForms;
using Xamarin.Forms;

namespace AutoCompleteSample
{
    public class App : Application
    {
        public App() => MainPage = new AutoCompletePage();
    }

    class AutoCompletePage : ContentPage
    {
        public AutoCompletePage()
        {
            Content = new SfAutoComplete
            {
                HeightRequest = 40,
                AutoCompleteSource = new List<string>
                {
                    "Edge",
                    "Firefox",
                    "Chrome",
                    "Opera",
                    "Safari",
                }
            };
        }
    }
}
```
