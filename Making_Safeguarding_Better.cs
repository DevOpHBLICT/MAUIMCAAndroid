using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

using Microsoft.Maui;


namespace mca
{






    public class Making_Safeguarding_Better : ContentPage
    {


        void OnyesButtonClicked(object sender, EventArgs e)
        {
            var tg = new Making_Safeguarding_Better();
            MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }


     





        public class GetFrontPage2
        {
            public String Image { get; set; }

            public string Name { get; set; }
            public GetFrontPage2(string name, string image)
            {
                Name = name;
                Image = image;


            }

        }


        public Making_Safeguarding_Better()
        {

            App.app_title = "Personal Safeguarding";
            Title = "Personal Safeguarding";
           

            BackgroundColor = Color.FromHex("FFFFFF");




            var browser = new BaseUrlWebView(); // temporarily use this so we can custom-render in iOS 
            var htmlSource = new HtmlWebViewSource();
            /*
htmlSource.Html = @"<html> 
 <head> 
 <link rel=""stylesheet"" href=""default.css""> 
 </head> 
 <body> 
 <h1>Xamarin.Forms</h1> 
 <p>The CSS and image are loaded from local files!</p> 
 <img src='XamarinLogo.png'/> 
 <p><a href=""local.html"">next page</a></p> 
 </body> 
 </html>";
            */
            var s = @"<html> 
 <head> 
 <link rel=""stylesheet"" href=""default.css""> 
<style>    
*{
font-family:'HelveticaNeue-Light','Helvetica','Arial';
font-size:22px;
}
#triangle-right {
  width: 0; 
  height: 0; 
  border-top: 15px solid transparent;
  border-bottom: 15px solid transparent;
  
  border-left: 15px solid #FCDED4;
}
</style>
 </head> 
 <body> 
<h3 style='color:#953735'>Making Safeguarding Personal </h3>

<div align='center'>

</div>
<table><tr><td style='vertical-align:top;margin-top:8px'> <div id='triangle-right'></div></td><td> Is a shift in culture and professional practice. </td></tr> 
<table><tr><td style='vertical-align:top;margin-top:8px' > <div id='triangle-right'></div></td><td>It is about having conversations with people about how we might respond in safeguarding situations to enhance involvement, choice and control as well as improving quality of life, wellbeing & safety.  </td></tr>
<table><tr><td style='vertical-align:top;margin-top:8px'> <div id='triangle-right'></div></td><td>It is about empowering the adult at risk to ensure that their wishes/ desired outcomes are considered as part of the safeguarding process. </td></tr>
<table><tr><td style='vertical-align:top;margin-top:8px'> <div id='triangle-right'></div></td><td>It is about seeing people as experts in their own lives and working alongside them. </td></tr>
<table><tr><td style='vertical-align:top;margin-top:8px' > <div id='triangle-right'></div></td><td>The alerter must note the person's wishes but still has a duty to raise any safeguarding concerns that are disclosed, witnessed or suspected to the Local Authority.  </td></tr></table>

 </ body> 
 </html>";

           

            htmlSource.Html = s;

           // htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            browser.Source = htmlSource;



            Content = browser;


        }
    }
}
