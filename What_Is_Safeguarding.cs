
using System;
using System.Collections.Generic;

using System.Text;

using Microsoft.Maui;
using Font = Microsoft.Maui.Font;

namespace mca
{


    

    

    public class What_Is_Safeguarding : ContentPage
    {

        void OnyesButtonClicked(object sender, EventArgs e)
        {
            var tg = new Categories_Abuse();
            MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }




        public void refresh()
        {
            //         listView.ItemsSource = _database.GetContents();
        }


        public What_Is_Safeguarding(String Titles)
        {
            var s = new Label { HorizontalTextAlignment = TextAlignment.Center,
                Text = "What is Safeguarding?", TextColor = Color.FromHex("953735")};


            App.app_title = Titles;
            Title = Titles;
        
            Label title = null;

        BackgroundColor = Color.FromHex("FFFFFF");

       


                  title = new Label
                {
                Text = "What Is Safeguarding",
           //     XAlign = TextAlignment.Center,
             //    FontSize = Font.SystemFontOfSize(30),
                  };

                title.TextColor = Color.FromHex("#953735");

     

          

            var browser = new BaseUrlWebView(); // temporarily use this so we can custom-render in iOS 
            var htmlSource = new HtmlWebViewSource();


            browser.HeightRequest = 600;
  
       //     htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            browser.Source = htmlSource;

            //      color:#878787;
            //color:#878787;
            var ss =@"<html> 
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

html, body {  padding: 0; margin: 0; }
*{
font-size:22px;
}
body
{
margin:10px;
}
}
</style>
<meta name='viewport' content='width =device -width, initial-scale = 1.0, maximum-scale = 1.0'>
                 </head> 
 <body>
<h2><b id ='bb'>What is Safeguarding? </b></h2>
<b id ='bb'>Safeguarding means:</b>
<br/><b id='bb'>Protecting </b> an adult's right to live in safety, free from abuse and neglect.</div>

<br/><b id='bb'>Stop abuse</b> or neglect where possible.</div>

<br/><b id='bb'>Prevent</b> harm and reduce the risk of abuse or neglect in a way that supports them in making choices and having control about how they want to live.</div>

<br/><b id='bb'>Raise</b> public awareness to enable communities as a whole, together with professionals, help to prevent, identify and respond to abuse and neglect.</div>

  </body>
</html>";


          
            htmlSource.Html = ss;

           Button yes = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), Text = "Categories of Abuse", IsVisible = true, ImageSource = "tick", BackgroundColor = Color.FromHex("#953735"), TextColor = Color.FromHex("FFFFFF") };
            yes.Clicked += OnyesButtonClicked;
            yes.HeightRequest = 50;

            var x = new StackLayout
            {
                VerticalOptions=LayoutOptions.Start,
                Children = {
                    browser,   
                    
                }
            };

            var y = new StackLayout
            {
                Padding=5,
                VerticalOptions = LayoutOptions.EndAndExpand,
                Children =
                {
                    yes
                }
            };
            Content = new StackLayout { Children = { x, y } };
   

         
        } 
    }
}