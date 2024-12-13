namespace PokeCLI.Agent;

using PokeCLI.Player;
using PokeCLI.Pokemon;

class Agent : Player {
    public Agent(string name) : base(name) {
        this.name = name;
        this.pokeCount = 0;
    }

    public int selectPokemon(string[] pokeList) {
        Random choice = new Random();
        int count = 0;
        foreach(string name in pokeList) {
            if(name != "") {
                count++;
            }
        }

        return choice.Next(0, count);
    }

    public void curateTeam(string[] pokeList) {
        int selection;
        for(int i = 0; i < 6; i++) {
            do {
                selection = selectPokemon(pokeList);
            } while (pokeList[selection] == "");
            this.addToTeam(pokeList[selection]);
            pokeList[selection] = "";
        }
    }

    public void showTeam() {
        foreach(Pokemon pokemon in this.team) {
            Console.Write(pokemon.name + " ");
        }
    }

    
}
