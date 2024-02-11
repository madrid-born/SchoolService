namespace SchoolService.Models ;

    public class Message
    {
        public string Text { get; set; }
        public bool Sender { get; set; } // True means the client and false means the other one

        public Message(string text, bool sender)
        {
            Text = text;
            Sender = sender;
        }
    }