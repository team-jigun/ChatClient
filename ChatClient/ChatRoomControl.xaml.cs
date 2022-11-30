using ChatClient.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatClient
{
    /// <summary>
    /// ChatRoomControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ChatRoomControl : UserControl
    {
        private string _roomName = "";
        private ObservableCollection<ChatMessage> _messages = new ObservableCollection<ChatMessage>();

        public string RoomName { get => _roomName; }
        public ObservableCollection<ChatMessage> Messages { get => _messages; }
        public ChatRoomControl()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void SendBtnClick(object sender, RoutedEventArgs e)
        {

        }

        private void AddPersonBtnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}