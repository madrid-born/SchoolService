namespace SchoolService.Models ;

    public class Job
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public int Wage { get; set; }
        public List<Ability> NeededAbilities { get; set; }

        public Job(string title, string imagePath, int wage, List<Ability> abilities)
        {
            Title = title;
            ImagePath = imagePath;
            Wage = wage;
            NeededAbilities = abilities;
        }

        public void AddAbility(Ability ability)
        {
            NeededAbilities.Add(ability);
        }
    }