
using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Maui;

namespace mca
{






    public class Categories_Abuse : ContentPage
    {
        private ListView Categories;



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


        public void refresh()
        {
            //         listView.ItemsSource = _database.GetContents();
        }

        public void Physical_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Categories of Abuse";
            var tg = new d("3", "Physical Abuse", "#953735");
            MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
        public void Domestic_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Categories of Abuse";
            var tg = new d("4", "Domestic Abuse", "#d99694");
            MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }

        public void Sexual_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Categories of Abuse";
            var tg = new d("5", "Sexual Abuse", "#e6b9b8"); ;
           MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }


        public void Psychological_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Categories of Abuse";
            var tg = new d("6", "Psychological Abuse", "#bfbfbf");
           MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
        public void Financial_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Categories of Abuse";
            var tg = new d("7", "Financial or Material Abuse", "#bfbfbf");
           MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
        public void Modern_Slavery_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Categories of Abuse";
            var tg = new d("8", "Modern Slavery", "#bfbfbf");
           MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }

        public void Discriminatory_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Categories of Abuse";
            var tg = new d("9", "Discriminatory Abuse", "#bfbfbf");
            MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }

        public void Organisational_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Categories of Abuse";
            var tg = new d("10", "Organisational Abuse", "#bfbfbf");
           MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
        public void Neglect_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Categories of Abuse";
            var tg = new d("11", "Neglect and acts of omission", "#bfbfbf");
            MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }

        public void Self_Neglect_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Categories of Abuse";
            var tg = new d("12", "Self Neglect", "#bfbfbf");
          MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }




        public Categories_Abuse()
        {


            App.app_title = "Categories of Abuse";
            Title = "Categories of Abuse";
            BackgroundColor = Color.FromHex("FFFFFF");
         
            Label title = null;

            Categories = new ListView
            {

                SeparatorColor = Color.FromHex("#ddd"),
            };

        




            Categories.ItemSelected += (sender, e) =>
            {


                if (e.SelectedItem == null) return;
                var user = (GetFrontPage)e.SelectedItem;

                
                if (user.Name == "Physical abuse")
                {
                    App.app_title = "Categories of Abuse";
                    var tg1 = new d("3", "Physical Abuse", "#953735");
                  MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg1));
                }
                if (user.Name == "Domestic abuse")
                {
                    App.app_title = "Categories of Abuse";
                    var tg2 = new d("4", "Domestic Abuse", "#d99694");
                MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg2));

                }
                if (user.Name == "Sexual abuse")
                {
                    App.app_title = "Categories of Abuse";
                    var tg3 = new d("5", "Sexual abuse", "#e6b9b8"); ;
                    MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg3));
                }
                if (user.Name == "Psychological abuse")
                {
                    App.app_title = "Categories of Abuse";
                    var tg4 = new d("6", "Psychological abuse", "#bfbfbf");
                    MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg4));
                }


                if (user.Name == "Financial or material abuse")
                {
                    App.app_title = "Categories of abuse";
                    var tg5 = new d("7", "Financial or material abuse", "#bfbfbf");
                    MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg5));
                }
                if (user.Name == "Modern slavery")
                {
                    App.app_title = "Categories of Abuse";
                    var tg6 = new d("8", "Modern slavery", "#bfbfbf");
                    MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg6));

                }
                if (user.Name == "Discriminatory abuse")
                {

                    App.app_title = "Discriminatory abuse";
                    var tg7 = new d("9", "Discriminatory Abuse", "#bfbfbf");
                    MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg7));
                }

                if (user.Name == "Organisational abuse")
                {

                    App.app_title = "Categories of Abuse";
                    var tg8 = new d("10", "Organisational Abuse", "#bfbfbf");
                    MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg8));

                }
                if (user.Name == "Neglect and acts of omission")
                {
                    App.app_title = "Categories of Abuse";
                    var tg9 = new d("11", "Neglect and acts of omission", "#bfbfbf");
                    MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg9));
                }

                if (user.Name == "Self neglect")
                {
                    App.app_title = "Categories of Abuse";
                    var tg10 = new d("12", "Self neglect", "#bfbfbf");
                    MainThread.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg10));
                }
//

                if (e.SelectedItem == null) return; // don't do anything if we just de-selected the row
                                                    // do something with e.SelectedItem
                ((ListView)sender).SelectedItem = null; // de-select the row

            };
       
    

    //  BackgroundColor = Color.FromHex("#e6b9b8");

    var s = new Label {HeightRequest=0 };
           

            BackgroundColor = Color.FromHex("FFFFFF");

            title = new Label
            {
                Text = "HSAB SAFA",
           //     XAlign = TextAlignment.Center,
             //   Font = Font.SystemFontOfSize(30),
                BackgroundColor = Color.FromHex("FFFFFF")
            };

            title.TextColor = Color.FromHex("#953735");



            Button Physical_Abuse = new RoundedCornersButton { TextColor = Color.FromHex("FFFFFF"), BackgroundColor = Color.FromHex("#8b3836"), BorderWidth = 2,BorderColor= Color.FromHex("#953735"), Text = "Physical", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
             Button Domestic_Abuse = new RoundedCornersButton { TextColor = Color.FromHex("FFFFFF"), BackgroundColor = Color.FromHex("#ab4844"), BorderWidth = 2, BorderColor = Color.FromHex("#953735"), Text = "Domestic", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
             Button Sexual_Abuse = new RoundedCornersButton { TextColor = Color.FromHex("FFFFFF"), BackgroundColor = Color.FromHex("#bd6462"), BorderWidth = 2, BorderColor = Color.FromHex("#953735"), Text = "Sexual", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
              Button Psychological_Abuse = new RoundedCornersButton { TextColor = Color.FromHex("FFFFFF"), BackgroundColor = Color.FromHex("#c98585"), BorderWidth = 2, BorderColor = Color.FromHex("#953735"), Text = "Psychological", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
              Button Financial_Abuse = new RoundedCornersButton { TextColor = Color.FromHex("#8b3836"), BackgroundColor = Color.FromHex("#d5a7a7"), BorderWidth = 2, BorderColor = Color.FromHex("#953735"), Text = "Financial/Material", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
              Button Modern_Slavery = new RoundedCornersButton { TextColor = Color.FromHex("#8b3836"), BackgroundColor = Color.FromHex("#e3c7c7"), BorderWidth = 2, BorderColor = Color.FromHex("#953735"), Text = "Modern Slavery", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
              Button Discriminatory_Abuse = new RoundedCornersButton { TextColor = Color.FromHex("#8b3836"), BackgroundColor = Color.FromHex("#d5a7a7"), BorderWidth = 2, BorderColor = Color.FromHex("#953735"), Text = "Discriminatory", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
              Button Organisational_Abuse = new RoundedCornersButton { TextColor = Color.FromHex("FFFFFF"), BackgroundColor = Color.FromHex("#c98585"), BorderWidth = 2, BorderColor = Color.FromHex("#953735"), Text = "Organisational", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
              Button Neglect_Abuse = new RoundedCornersButton { TextColor = Color.FromHex("FFFFFF"), BackgroundColor = Color.FromHex("#bd6462"), BorderWidth = 2, BorderColor = Color.FromHex("#953735"), Text = "Neglect and acts of omission", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button Self_Neglect = new RoundedCornersButton { TextColor = Color.FromHex("FFFFFF"), BackgroundColor = Color.FromHex("#ab4844"), BorderWidth = 2, BorderColor = Color.FromHex("#953735"), Text = "Self-neglect", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };




            var grid = new Grid
            {
                Padding = 10,
                RowSpacing = 5
            };





            Physical_Abuse.Clicked += Physical_Abuse_Clicked;
            Domestic_Abuse.Clicked += Domestic_Abuse_Clicked;
            Sexual_Abuse.Clicked += Sexual_Abuse_Clicked;
            Psychological_Abuse.Clicked += Psychological_Abuse_Clicked;
            Financial_Abuse.Clicked += Financial_Abuse_Clicked;
            Modern_Slavery.Clicked += Modern_Slavery_Clicked;
            Discriminatory_Abuse.Clicked += Discriminatory_Abuse_Clicked;
            Organisational_Abuse.Clicked += Organisational_Abuse_Clicked;
            Neglect_Abuse.Clicked += Neglect_Abuse_Clicked;
            Self_Neglect.Clicked += Self_Neglect_Abuse_Clicked;






            var logo = new StackLayout
            {
                Padding = new Thickness(2, 2, 2, 2),
                Orientation = StackOrientation.Horizontal,

                Children = {
          new Image {
                                
                           //     BackgroundColor =Color.FromHex("FFFFFF"),
                                  VerticalOptions = LayoutOptions.CenterAndExpand,
                           HorizontalOptions = LayoutOptions.CenterAndExpand,
                          HeightRequest=25,
                        //   WidthRequest=90,
                   //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                            Source =ImageSource.FromFile( "HSAB.png" )
            }
                }

            };
            var i = new Image
            {

                //     BackgroundColor =Color.FromHex("FFFFFF"),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                HeightRequest = 70,
                //   WidthRequest=90,
                //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                Source = ImageSource.FromFile("Page1.png")
            };

            var intro = new Label();
            intro.Text= "Please select from the categories below:";
            intro.TextColor = Color.FromHex("#953735");
            intro.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
            var k = new StackLayout
            {
                HeightRequest = 800,
                Padding = 5,
                //  BackgroundColor = Color.FromHex("FFFFFF"),
                Children = {
                   s,
         //          intro,
                         Physical_Abuse,
            Domestic_Abuse,
            Sexual_Abuse,
            Psychological_Abuse,
            Financial_Abuse,
            Modern_Slavery,
            Discriminatory_Abuse,
            Organisational_Abuse,
            Neglect_Abuse,
            Self_Neglect,
        // intro,
          Categories

                }
            };

             
            Content = new ScrollView { Content =k  };


        }
    }
}