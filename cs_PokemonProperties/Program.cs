namespace cs_PokemonProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pokemon
            Pokemon p1 = new Pokemon("Pikachu", 1, 100);

            //Trainers
            Trainer trainer1 = new Trainer("Ash");

            trainer1.AddPokemon(p1);

            trainer1.ShowTeam();

        }
    }
}
