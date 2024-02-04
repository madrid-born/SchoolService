namespace SchoolService.Models ;

    public class Ability
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public Ability(string name, int level)
        {
            Name = name;
            Level = level;
        }
    }