using SchoolService.Models;

namespace SchoolService.Temp ;

    public class RandomDatas
    {
        private static readonly List<string> PersonNames = new List<string>()
        {
            "Ali", "Reza", "mamad", "meiti", "aria", "dariush", "hashem", "saber"
        };

        private static readonly List<string> JobTitle = new List<string>()
        {
            "Physical Therapist","Environmental scientist","Mathematician","Secretary","Childcare worker","Construction Manager","Electrician","Interpreter & Translator","Paramedic","Urban Planner"
        };

        private static readonly List<string> AbilityTitle = new List<string>()
        {
            "printing", "vacuuming", "moping", "reading", "cleaning", "fixing", "talking",
        };
        
        private static readonly List<string> SuggestionTitle = new List<string>()
        {
            "chize khafan", "chize sade", "chize ajib", "chize kool", "chize bahal",
        };
        
        private static readonly List<string> SuggestionDetail = new List<string>()
        {
            "khafane", "sade'e", "ajibe", "koole", "bahale",
        };
        
        private static readonly List<string> SuggestionImplement = new List<string>()
        {
            "jaye khafan", "jaye sade", "jaye ajib", "jaye kool", "jaye bahal", "hich ja",
        };

        private static readonly List<string> TextMessages = new List<string>()
        {
            "Hey there", "how you doing", "what's up?", "will you give me any discount?", "where are you?", "come here and you will see", "will you do me a favor?", "will you come here?", " will you do the job?", "someone else took the job", "im sorry there is no way", "nothing seems good there", "show me the problem", "send me your address", "no way", "come on", "so do we have a deal", "i will do it", "show me the path", "thanks", "your welcome", "this is great", "that's not good"
        };
        
        // private static readonly List<>

        private static List<Ability> AbilityGenerator(int num)
        {
            var random = new Random();
            var result = new List<Ability>();
            for (int i = 0; i < num; i++)
            {
                var name = AbilityTitle[random.Next(AbilityTitle.Count)];
                var level = random.Next(10);
                var ability = new Ability(name, level);
                result.Add(ability);
            }
            return result;
        }
        
        public static List<Job> JobGenerator(int num)
        {
            var random = new Random();
            var result = new List<Job>();
            for (int i = 0; i < num; i++)
            {
                var title = JobTitle[random.Next(JobTitle.Count)];
                var image = $"p{random.Next(1,18)}";
                var wage = random.Next(10000, 100000);
                wage -= wage % 1000;
                var job = new Job(title, image, wage, AbilityGenerator(2));
                result.Add(job);
            }
            return result;
        }
        
        public static List<Worker> WorkerGenerator(int num)
        {
            var random = new Random();
            var result = new List<Worker>();
            for (int i = 0; i < num; i++)
            {
                var name = PersonNames[random.Next(PersonNames.Count)];
                var age = random.Next(18,35);
                var worker = new Worker(name, age, AbilityGenerator(5));
                var image = $"p{random.Next(1,18)}";
                worker.AddImage(image);
                result.Add(worker);
            }
            return result;
        }

        public static List<Suggestion> SuggestionGenerator(int num)
        {
            var random = new Random();
            var result = new List<Suggestion>();
            for (int i = 0; i < num; i++)
            {
                var title = SuggestionTitle[random.Next(SuggestionTitle.Count)];
                var detail = SuggestionDetail[random.Next(SuggestionDetail.Count)];
                var implemented = SuggestionImplement[random.Next(SuggestionImplement.Count)];
                var suggestion = new Suggestion(title, detail, implemented);
                suggestion.AddWorker(WorkerGenerator(1)[0]);
                result.Add(suggestion);
            }
            return result;
        }
        
        public static List<Message> MessageGenerator(int num)
        {
            var random = new Random();
            var result = new List<Message>();
            var booleans = new List<bool>() {true, false};
            for (int i = 0; i < num; i++)
            {
                var text = TextMessages[random.Next(TextMessages.Count)];
                var sender = booleans[random.Next(booleans.Count)];
                var message = new Message(text, sender);
                result.Add(message);
            }
            return result;
        }
        
        public static List<Chat> ChatGenerator(int num)
        {
            var random = new Random();
            var result = new List<Chat>();
            for (int i = 0; i < num; i++)
            {
                var job = JobGenerator(1)[0];
                var messages = MessageGenerator(10);
                var chat = new Chat(job, messages);
                result.Add(chat);
            }
            return result;
        }
    }