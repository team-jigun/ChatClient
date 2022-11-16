using ChatClient.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using RestSharp;

namespace ChatClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Frame PageFrame { get; set; }
        public static AccessTokenModel? AccessToken { get; set; }
        public static RestClient Client = new RestClient();
    }
}
