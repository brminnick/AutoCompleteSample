using System.Collections.Generic;
using Syncfusion.SfAutoComplete.XForms;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace AutoCompleteSample
{
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
            }.CenterVertical().FillExpandHorizontal();
        }
    }
}
