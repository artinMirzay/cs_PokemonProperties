namespace cs_PokemonProperties
{
    public class Trainer
    {
        //Auto property
        public string Name { get; private set; }

        //Field
        private List<Pokemon> team = new List<Pokemon>();

        //Constructor
        public Trainer(string name)
        {
            Name = name;
        }

        public void AddPokemon(Pokemon p)
        {
            team.Add(p);
        }

        public void ShowTeam()
        {
            Console.WriteLine($"{Name}'s Team: ");
            foreach (Pokemon p in team)
            {
                Console.WriteLine(p.Info());
            }
        }
    }
}
