using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using mca;
using Microsoft.Maui ;

namespace mca
{




    public class Contents : ContentPage
    {





     

        public void Mental_Capacity_Assessments_Clicked(object sender, EventArgs args)
        {
         
            App.app_title = "Assessing Capacity Prompts";
            var tg = new d("1", "Assessing Capacity Prompts", "#953735");
           MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
        public void Best_Interest_Decision_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Best Interests Decision";
            var tg = new d("22", "Best Interests Decision", "#d99694");
            MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }

        public void IMCA_Referrals_Clicked(object sender, EventArgs args)
        {
            App.app_title = "IMCA Referrals";
            var tg = new d("38", "IMCA Referrals", "#e6b9b8"); ;
            MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }


        public void DOLS_Appplication_Clicked(object sender, EventArgs args)
        {
            App.app_title = "DOLS Applications";
            var tg = new d("42", "DOLS Applications", "#bfbfbf");
         MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }


        public Contents()
        {


            App.app_title = "HSAB MCA Prompts";
            Title = "HSAB MCA Prompts";
            BackgroundColor = Color.FromHex("FFFFFF");

            Label title = null;

            //  BackgroundColor = Color.FromHex("#e6b9b8");


       

            BackgroundColor = Color.FromHex("FFFFFF");

            title = new Label
            {
                Text = "HSAB MCA Prompts",
                HorizontalTextAlignment= TextAlignment.Center,
                FontSize = 30,
                BackgroundColor = Color.FromHex("FFFFFF")
            };

            

            Button Mental_Capacity_Assessments = new Button { Text = "Assessing Capacity prompts", BackgroundColor = Color.FromHex("#953735"), TextColor = Color.FromHex("FFFFFF"), VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button Best_Interest_Decision = new Button { Text = "Best Interests Decision prompts", BackgroundColor = Color.FromHex("#d99694"), TextColor = Color.FromHex("#953735"), VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button IMCA_Referrals = new Button { Text = "IMCA Referrals prompts", BackgroundColor = Color.FromHex("#e6b9b8"), TextColor = Color.FromHex("#953735"), HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button DOLS_Applications = new Button { Text = "DOLS Applications prompts", BackgroundColor = Color.FromHex("#bfbfbf"), TextColor = Color.FromHex("#953735"), HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };


    


            Mental_Capacity_Assessments.Clicked += Mental_Capacity_Assessments_Clicked;
            Best_Interest_Decision.Clicked += Best_Interest_Decision_Clicked;
            IMCA_Referrals.Clicked += IMCA_Referrals_Clicked;
            DOLS_Applications.Clicked += DOLS_Appplication_Clicked;

            this.Padding = new Thickness(5, 5, 5, 5);
            var StackPanel = new StackLayout
            {

                //        BackgroundColor = Color.White,
                Children =
                {


                    new Image {

                           //     BackgroundColor =Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                Source =ImageSource.FromFile( "contents.png" )}

                        ,
                //    listView,
                new StackLayout
                {
                    Spacing =1,
                    Orientation=StackOrientation.Horizontal,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                      HorizontalOptions = LayoutOptions.FillAndExpand,
                    Children= {

                Mental_Capacity_Assessments,
             //   Mental_Capacity_Assessments_Info
                }
                },

                    new StackLayout
                {
                    Spacing =1,
                     VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Orientation=StackOrientation.Horizontal,
                    Children= {

                Best_Interest_Decision,
               // Best_Interest_Decision_Info
                }
                },

  new StackLayout
                {
                    Spacing =1,
                    Orientation=StackOrientation.Horizontal,
                     VerticalOptions = LayoutOptions.FillAndExpand,
                      HorizontalOptions = LayoutOptions.FillAndExpand,
                    Children= {

                IMCA_Referrals,
               // IMCA_Referrals_Info,
                }
                },

  new StackLayout
                {
                      Spacing =1,
                       VerticalOptions = LayoutOptions.FillAndExpand,
                      HorizontalOptions = LayoutOptions.FillAndExpand,
                    Orientation=StackOrientation.Horizontal,
                    Children= {
                    DOLS_Applications,
               // DOLS_Applications_Info,
                }
                },

  new StackLayout
  {
       VerticalOptions = LayoutOptions.FillAndExpand,
       HorizontalOptions = LayoutOptions.FillAndExpand,
      Orientation=StackOrientation.Horizontal,
      BackgroundColor=Color.FromHex("FFFFFF"),
      Padding=5,
      Children= {
             new Image {
 
                           //     BackgroundColor =Color.White,
                                  VerticalOptions = LayoutOptions.FillAndExpand,
                           HorizontalOptions = LayoutOptions.StartAndExpand,
                           HeightRequest=90,
                           WidthRequest=180,
                                  Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                            Source =ImageSource.FromFile( "hsab_logo1.png" )},

          new Image {
                                
                           //     BackgroundColor =Color.White,
                                  VerticalOptions = LayoutOptions.FillAndExpand,
                           HorizontalOptions = LayoutOptions.EndAndExpand,
                          HeightRequest=45,
                           WidthRequest=90,
                   //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                            Source =ImageSource.FromFile( "hbl.png" )},

      }
  },


                        }

            };

         

            Content = StackPanel;
        }
    }
}