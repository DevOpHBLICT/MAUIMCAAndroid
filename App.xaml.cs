
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui;
using System.Net.Http;

using System.Xml.Linq;
using mca;

namespace mca
{
    public partial class App : Application
    {
        public static string data;
        public static string version_no;
        public static string current_version;
        public static int loaded;
        public static int Network_Connection;
        public static List<Pages> pages = new List<Pages>();

        public static String app_title { get; set; }

        public static NavigationPage NavPage { get; set; }

        public App()
        {
            loaded = 0;
            Resources = new ResourceDictionary();
            Resources.Add("Wine_Red", Color.FromHex("953735"));
            NavPage = new NavigationPage(new Contents());
                 App.NavPage.BarBackgroundColor = (Color)App.Current.Resources["Wine_Red"];
                App.NavPage.BarTextColor = Color.FromHex("FFFFFF");
                App.NavPage.ToolbarItems.Add(new ToolbarItem
                {

                    //  Text = "Home",
                    //    Icon ="back.png",
                   IconImageSource= "home.png",
                    //    Command = new Command(() => nav.PushAsync(new Contents(database))),
                    Command = new Command(() => App.NavPage.PopToRootAsync())
                });
                App.NavPage.ToolbarItems.Add(new ToolbarItem
                {

                    Text = "i",
                    IconImageSource = "info2.png",

                    Command = new Command(() =>

                        App.NavPage.PushAsync(new info_2(app_title))

                     )
                });
            
            MainPage = NavPage;

        }



        public static ListView p;


        protected override void OnStart()
        {
            //    CheckCurrentVersion();

            //    CheckVersion();


            //    if (Convert.ToInt32(version_no) > Convert.ToInt32(current_version))
            //    {
            //        GetOnlineData();
            //    }


            //    SaveOnlineData();


            var st = "\t\u2022 This app is intended for use by Health and Social Care Professionals. ";
            st = st + "It is meant to be used as an aid for decision making and does not replace clinical judgement\r\n";
            st = st + "\t\u2022 Click on each button and information section to see more guidance\r\n ";
            st = st + "\t\u2022 This app will not provide enough information to adequately document the decision or decision making process, it is essential that you document all decisions, how they were made and who else was involved\r\n ";
            st = st + "\t\u2022 This app is an adjunct to your organisations policies\r\n ";
            st = st + "\t\u2022 The guidance in this app does not relate to a Deprivation of Liberty in the persons own home\r\n ";


            var answer = App.Current.MainPage.DisplayAlert("Disclaimer", st, "I agree");
            // Handle when your app starts
        }




        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }
    }
}