
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

using Microsoft.Maui;

namespace mca
{

    //asdfasdf




    public class Recognising_Abuse : ContentPage
    {
      

        void OnyesButtonClicked(object sender, EventArgs e)
        {
            var tg = new Recognising_Abuse2();
           MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }


        
        public class GetFrontPage
        {
            public String Image { get; set; }

            public string Name { get; set; }
            public GetFrontPage(string name, string image)
            {
                Name = name;
                Image = image;


            }

        }

        [Obsolete]
        public Recognising_Abuse()
        {

         
    
            App.app_title = "Recognising Abuse";
            Title = "Recognising Abuse";
        
            var s = new Label { HeightRequest = 0 };
              BackgroundColor = Color.FromHex("#ffffff");
           



         
            


          
            var browser = new BaseUrlWebView(); // temporarily use this so we can custom-render in iOS 
            var htmlSource = new HtmlWebViewSource();
           // browser.HeightRequest = 500;

         


            htmlSource.Html = @"<html> 
 <head> 
<head> 
<style>
*{
font-family:'HelveticaNeue-Light','Helvetica','Arial';
font-size:22px;
}
#id
{
color:#923b3d !important;
}
b{
color:#923b3d !important;
}

html, body { padding: 0; margin: 0; }
*{
font-size:22px;
}
body
{
margin:5px;
}
}
</style>
</style>
<meta name='viewport' content='width =device -width, initial-scale = 1.0, maximum-scale = 1.0'>
                 </head> 
 <body>
<h2><b id ='bb'> Recognising Abuse</b> </h2>
<h3><b id ='bb'>Risk</b></h3>Risk is not in itself a safeguarding issue, as not all risks will result in a negative impact on the individual.
<h3><b id='bb'>Abuse</b></h3>May be an isolated incident or multiple, affecting one or more people.
<h3><b id='bb'>Harm</b></h3> Should be taken to include not only ill treatment but also the impairment of, or avoidable deterioration in, physical or mental health and the impairment of physical, intellectual, emotional, social or behavioural development.</div>


  </body>
</html>";


       //     htmlSource.Html = "test";

         //   htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            browser.Source = htmlSource;

            Button yes = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), Text = "Next", IsVisible = true, ImageSource = "tick", BackgroundColor = Color.FromHex("#953735"), TextColor = Color.FromHex("FFFFFF") };
            yes.Clicked += OnyesButtonClicked;
            yes.HeightRequest = 50;
             Content = new StackLayout
            {
                // VerticalOptions = LayoutOptions.End,
                 Padding =5,
                Children = { browser, yes}
            };

            
          }
    }
}