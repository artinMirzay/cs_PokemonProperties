namespace cs_PokemonProperties
{
    public class Pokemon
    {
        //Auto properties, PascalCase
        public string Name { get; private set; }
        public int Level { get; set; }

        //Private field, encapsulation, HELT PRIVAT, can only be changed in its own class (uses its own get and set methods)
        //private int hp;

        //Property with private backing field
        private int hp;
        public int Hp
        {
            get { return hp; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Cannot be less than 0");
                    hp = 0;
                }
                else
                {
                    hp = value;
                }
            }
        }

        //Constructor
        public Pokemon(string name, int level, int startHp)
        {
            Name = name;
            Level = level;
            hp = startHp;
        }

        public string Info()
        {
            return $"[{Level}] {Name} | HP: {hp}";
        }

        public void Evolution(Pokemon pokemon, string name)
        {
            pokemon.Name = name;
        }




    }
}