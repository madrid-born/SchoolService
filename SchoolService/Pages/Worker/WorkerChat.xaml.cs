using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolService.Models;
using SchoolService.Temp;

namespace SchoolService.Pages.Worker ;

    public partial class WorkerChat : ContentPage
    {
        public WorkerChat()
        {
            InitializeComponent();
            Chats.ItemsSource = RandomDatas.ChatGenerator(4);
        }

        private async void ChatTapped(object sender, TappedEventArgs e)
        {
            var chatTapped =
                (sender as Grid)?.GestureRecognizers.OfType<TapGestureRecognizer>().FirstOrDefault()?.CommandParameter;

            if (chatTapped is Chat chat)
            {
                await Navigation.PushAsync(new ChatPage(chat));
            }
        }
    }