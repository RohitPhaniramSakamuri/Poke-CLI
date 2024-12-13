namespace PokeCLI.Player;

using System;
using System.Collections.Generic;
using PokeCLI.Pokemon;
using GameConstants;

class Player {
    public string name;
    public Pokemon[] team = new Pokemon[6];
    public int pokeCount;

    public Pokemon currentPoke = new Pokemon();

    public Player(string name) {
        this.name = name;
        this.pokeCount = 0;
    }

    public void addToTeam(string pokeName) {

        Dictionary<string, List<object>> pokeData = GameConstants.pokeData;
        Dictionary<string, List<object>> moveData = GameConstants.moveData;
        // Create an array for the moves
        string[] moveNames = {
            (string)pokeData[pokeName][2],
            (string)pokeData[pokeName][3],
            (string)pokeData[pokeName][4],
            (string)pokeData[pokeName][5]
        };

        // Handle optional type2 parameter
        string type1 = (string)pokeData[pokeName][9];
        string type2 = pokeData[pokeName].Count > 10 ? (string)pokeData[pokeName][10] : "";

        // Add Pokemon to the team
        this.team[pokeCount] = new Pokemon(
            pokeName, 
            Convert.ToSingle(pokeData[pokeName][1]), 
            moveNames,                                                 
            Convert.ToSingle(pokeData[pokeName][6]), 
            Convert.ToSingle(pokeData[pokeName][7]), 
            Convert.ToSingle(pokeData[pokeName][8]), 
            type1,                                   
            type2
            //status by default is ""                                
        );
        pokeCount++;
    }

    public void setCurrentPoke(Pokemon choice) {
        if(choice.status == "fnt") {}

        this.currentPoke = choice;
        Console.WriteLine(this.name + " picked " + this.currentPoke.name + "!");
        return;
    }
}
