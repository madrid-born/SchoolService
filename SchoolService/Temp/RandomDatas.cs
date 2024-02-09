using SchoolService.Models;

namespace SchoolService.Temp ;

    public class RandomDatas
    {
        private static List<string> _personNames = new List<string>()
        {
            "Ali", "Reza", "mamad", "meiti", "aria", "dariush", "hashem", "saber"
        };

        private static List<string> _jobTitle = new List<string>()
        {
            "Physical Therapist",
            "Environmental scientist",
            "Mathematician",
            "Secretary",
            "Childcare worker",
            "Construction Manager",
            "Electrician",
            "Interpreter & Translator",
            "Paramedic",
            "Urban Planner"
        };

        private static List<string> _abilityTitle = new List<string>()
        {
            "printing", "vacuuming", "moping", "reading", "cleaning", "fixing", "talking",
        };
        
        private static List<string> _suggestionTitle = new List<string>()
        {
            "chize khafan", "chize sade", "chize ajib", "chize kool", "chize bahal",
        };
        
        private static List<string> _suggestionDetail = new List<string>()
        {
            "khafane", "sade'e", "ajibe", "koole", "bahale",
        };
        
        private static List<string> _suggestionImplement = new List<string>()
        {
            "jaye khafan", "jaye sade", "jaye ajib", "jaye kool", "jaye bahal", "hich ja",
        };
        
        private static List<Ability> AbilityGenerator(int num)
        {
            var random = new Random();
            var result = new List<Ability>();
            for (int i = 0; i < num; i++)
            {
                var name = _abilityTitle[random.Next(_abilityTitle.Count)];
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
                var title = _jobTitle[random.Next(_jobTitle.Count)];
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
                var name = _personNames[random.Next(_personNames.Count)];
                var age = random.Next(18,35);
                var worker = new Worker(name, age, AbilityGenerator(5));
                result.Add(worker);
            }
            return result;
        }

        public static List<Suggestion> WorkerSuggestion(int num)
        {
            var random = new Random();
            var result = new List<Suggestion>();
            for (int i = 0; i < num; i++)
            {
                var title = _suggestionTitle[random.Next(_suggestionTitle.Count)];
                var detail = _suggestionDetail[random.Next(_suggestionDetail.Count)];
                var implemented = _suggestionImplement[random.Next(_suggestionImplement.Count)];
                var suggestion = new Suggestion(title, detail, implemented);
                result.Add(suggestion);
            }
            return result;
        }
    }