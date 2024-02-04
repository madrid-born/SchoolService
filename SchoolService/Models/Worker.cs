namespace SchoolService.Models ;

    public class Worker
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Ability> Abilities { get; set; }
        public string ImagePath { get; set; }

        public Worker(string name, int age, List<Ability> abilities)
        {
            Name = name;
            Age = age;
            Abilities = abilities;
        }
        
        public void AddAbility(Ability ability)
        {
            Abilities.Add(ability);
        }
    }