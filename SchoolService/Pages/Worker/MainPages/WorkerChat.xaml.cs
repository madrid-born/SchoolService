using SchoolService.Models;
using SchoolService.Pages.Worker.SingleContentPages;
using SchoolService.Temp;

namespace SchoolService.Pages.Worker.MainPages ;

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