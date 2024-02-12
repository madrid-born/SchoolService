namespace SchoolService.Models ;

    public class Message
    {
        public string Text { get; set; }
        public bool Sender { get; set; } // True means the client and false means the other person 
        public DateTime Time { get; set; }

        public Message(string text, bool sender)
        {
            Text = text;
            Sender = sender;
        }
    }