using ChatClient.Models;
<<<<<<< HEAD
using RestSharp;
=======
>>>>>>> 6a1d140258e665c9376aafc4701a303190fcaa02
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ChatClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Frame PageFrame { get; set; }
        public static AccessTokenModel? AccessToken { get; set; }
<<<<<<< HEAD

        public static RestClient client = new RestClient();
=======
>>>>>>> 6a1d140258e665c9376aafc4701a303190fcaa02
    }
}
