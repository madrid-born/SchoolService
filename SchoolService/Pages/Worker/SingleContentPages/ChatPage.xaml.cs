using SchoolService.Models;

namespace SchoolService.Pages.Worker.SingleContentPages ;

    public partial class ChatPage : ContentPage
    {
        public ChatPage(Chat chat)
        {
            InitializeComponent();
            messsages.ItemsSource = chat.Messages;
        }
    }