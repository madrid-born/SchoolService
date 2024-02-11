using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolService.Models;

namespace SchoolService.Pages.Worker ;

    public partial class ChatPage : ContentPage
    {
        public ChatPage(Chat chat)
        {
            InitializeComponent();
            messsages.ItemsSource = chat.Messages;
        }
    }