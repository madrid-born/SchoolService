namespace SchoolService.Models ;

    public class Chat
    {
        public Job Job { get; set; }
        public List<Message> Messages { get; set; }

        public Chat(Job job, List<Message> messages)
        {
            Job = job;
            Messages = messages;
        }
    }