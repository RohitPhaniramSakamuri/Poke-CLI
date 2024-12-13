namespace PokeCLI.GameConstants;

using PokeCLI.Pokemon;
using PokeCLI.Move;
using System.Collections.Generic;
static class GameConstants {
    public static readonly Dictionary<string, List<object>> moveData = new Dictionary<string, List<object>>();
    public static readonly Dictionary<string, List<object>> pokeData = new Dictionary<string, List<object>>();

    public static readonly Dictionary<string, List<string>> AttackSuperEffective = new Dictionary<string, List<string>>();
    public static readonly Dictionary<string, List<string>> AttackIneffective = new Dictionary<string, List<string>>();
    public static readonly Dictionary<string, List<string>> AttackNull = new Dictionary<string, List<string>>();

    static GameConstants() {
        //string name, int accuracy, string type, int pp, int power=0, int attInc=0, int defInc=0, int speedInc=0, int hpInc=0, string statChange=""
        moveData["Thunderbolt"] = new List<object> {"Thunderbolt", 100, "Electric", 15, 90, 0, 0, 0, 0, ""};
        moveData["Flamethrower"] = new List<object> {"Flamethrower", 100, "Fire", 15, 90, 0, 0, 0, 0, "Burn"};
        moveData["Slash"] = new List<object> {"Slash", 100, "Normal", 20, 70, 0, 0, 0, 0, ""};
        moveData["Aerial Ace"] = new List<object> {"Aerial Ace", 100, "Flying", 20, 60, 0, 0, 0, 0, ""};
        moveData["Dragon Claw"] = new List<object> {"Dragon Claw", 100, "Dragon", 15, 80, 0, 0, 0, 0, ""};
        moveData["Extreme Speed"] = new List<object> {"Extreme Speed", 100, "Normal", 5, 80, 0, 0, 0, 0, ""};
        moveData["Assurance"] = new List<object> {"Assurance", 100, "Dark", 10, 60, 0, 0, 0, 0, ""};
        moveData["Earthquake"] = new List<object> {"Earthquake", 100, "Ground", 10, 100, 0, 0, 0, 0, ""};
        moveData["Rock Slide"] = new List<object> {"Rock Slide", 90, "Rock", 10, 75, 0, 0, 0, 0, ""};
        moveData["Brick Break"] = new List<object> {"Brick Break", 70, "Fighting", 10, 75, 0, 0, 0, 0, ""};
        moveData["Surf"] = new List<object> {"Surf", 100, "Water", 15, 95, 0, 0, 0, 0, ""};
        moveData["Hydro Pump"] = new List<object> {"Hydro Pump", 80, "Water", 5, 110, 0, 0, 0, 0, ""};
        moveData["Skull Bash"] = new List<object> {"Skull Bash", 100, "Normal", 10, 100, 0, 0, 0, 0, ""};
        moveData["Shadow Ball"] = new List<object> {"Shadow Ball", 100, "Ghost", 15, 80, 0, 0, 0, 0, ""};
        moveData["Sludge Bomb"] = new List<object> {"Sludge Ball", 100, "Poison", 10, 90, 0, 0, 0, 0, ""};
        moveData["Psychic"] = new List<object> {"Psychic", 100, "Psychic", 10, 90, 0, 0, 0, 0, ""};
        moveData["Solar Beam"] = new List<object> {"Solar Beam", 100, "Grass", 10, 120, 0, 0, 0, 0, ""};
        moveData["Body Slam"] = new List<object> {"Body Slam", 100, "Normal", 15, 85, 0, 0, 0, 0, ""};
        moveData["Hyper Beam"] = new List<object> {"Hyper Beam", 90, "Normal", 5, 90, 0, 0, 0, 0, ""}; //TODO: Check the mechanics of this move
        moveData["Wing Attack"] = new List<object> {"Wing Attack", 100, "Flying", 35, 60, 0, 0, 0, 0, ""};
        moveData["Ice Beam"] = new List<object> {"Ice Beam", 100, "Ice", 10, 90, 0, 0, 0, 0, "Frz"};
        moveData["Splash"] = new List<object> {"Splash", 100, "Normal", 40, 0, 0, 0, 0, 0, ""};
        moveData["Draco Meteor"] = new List<object> {"Draco Meteor", 90, "Dragon", 5, 130, 0, 0, 0, 0, ""};
        moveData["Leaf Blade"] = new List<object> {"Leaf Blade", 100, "Grass", 15, 90, 0, 0, 0, 0, ""};
        moveData["Muddy Water"] = new List<object> {"Muddy Water", 85, "Water", 10, 95, 0, 0, 0, 0, ""};
        moveData["Tackle"] = new List<object> {"Tackle", 95, "Normal", 35, 40, 0, 0, 0, 0, ""};
        moveData["Hidden Power"] = new List<object> {"Hidden Power", 100, "Normal", 15, 60, 0, 0, 0, 0, ""};
        moveData["Megahorn"] = new List<object> {"Megahorn", 85, "Bug", 10, 120, 0, 0, 0, 0, ""};
        moveData["Meteor Mash"] = new List<object> {"Meteor Mash", 85, "Steel", 10, 100, 0, 0, 0, 0, ""};
        moveData["Crunch"] = new List<object> {"Crunch", 100, "Dark", 15, 80, 0, 0, 0, 0, ""};


        //string name, float hp, string[] moveNames, Dictionary<string, List<object>> moveData, float attack, float defense, float speed, string type1, string type2=""
        pokeData["Pikachu"] = new List<object> {"Pikachu", 274.00, "Thunderbolt", "Extreme Speed", "Brick Break", "Splash",  229.00, 196.00, 306.00, "Electric", ""}; //consider Raichu's in game stats?
        pokeData["Charizard"] = new List<object> {"Charizard", 360.00, "Flamethrower", "Slash", "Aerial Ace", "Dragon Claw", 293.00, 280.00, 328.00, "Fire", "Flying"};
        pokeData["Tyranitar"] = new List<object> {"Tyranitar", 404.00, "Assurance", "Earthquake", "Rock Slide", "Slash", 403.00, 350.00, 243.00, "Rock", "Dark"};
        pokeData["Blastoise"] = new List<object> {"Blastoise", 362.00, "Surf", "Hydro Pump", "Skull Bash", "Earthquake", 291.00, 328.00, 280.00, "Water", ""};
        pokeData["Gengar"] = new List<object> {"Gengar", 324.00, "Shadow Ball", "Sludge Bomb", "Psychic", "Splash", 251.00, 240.00, 250.00, "Ghost", "Poison"};
        pokeData["Venusaur"] = new List<object> {"Venusaur", 364.00, "Skull Bash", "Sludge Bomb", "Solar Beam", "Splash", 289.00, 291.00, 284.00, "Grass", "Poison"};
        pokeData["Snorlax"] = new List<object> {"Snorlax", 524.00, "Body Slam", "Hyper Beam", "Earthquake", "Splash", 350.00, 251.00, 174.00, "Normal", ""};
        pokeData["Dragonite"] = new List<object> {"Dragonite", 386.00, "Brick Break", "Wing Attack", "Splash", "Dragon Claw", 403.00, 317.00, 284.00, "Dragon", "Flying"};
        pokeData["Mewtwo"] = new List<object> {"Mewtwo", 416.00, "Psychic", "Brick Break", "Ice Beam", "Splash", 350.00, 306.00, 394.00, "Psychic", ""};
        pokeData["Rayquaza"] = new List<object> {"Rayquaza", 414.00, "Aerial Ace", "Draco Meteor", "Earthquake", "Ice Beam", 438.00, 306.00, 317.00, "Dragon", "Flying"};
        pokeData["Blaziken"] = new List<object> {"Blaziken", 364.00, "Flamethrower", "Brick Break", "Aerial Ace", "Extreme Speed", 372.00, 262.00, 284.00, "Fire", "Fighting"};
        pokeData["Sceptile"] = new List<object> {"Sceptile", 344.00, "Leaf Blade", "Body Slam", "Brick Break", "Slash", 295.00, 251.00, 372.00, "Grass", ""};
        pokeData["Swampert"] = new List<object> {"Swampert", 404.00, "Muddy Water", "Earthquake", "Hidden Power", "Surf", 350.00, 306.00, 240.00, "Water", "Ground"};   
        pokeData["Heracross"] = new List<object> {"Heracross", 364.00, "Megahorn", "Brick Break", "Tackle", "Slash", 383.00, 273.00, 295.00, "Bug", "Fighting"}; 
        pokeData["Articuno"] = new List<object> {"Articuno", 384.00, "Aerial Ace", "Ice Beam", "Wing Attack", "Slash", 295.00, 328.00, 295.00, "Ice", "Flying"};
        pokeData["Metagross"] = new List<object> {"Metagross", 364.00, "Meteor Mash", "Psychic", "Aerial Ace", "Shadow Ball", 405.00, 394.00, 262.00, "Steel", "Psychic"};
        pokeData["Houndoom"] = new List<object> {"Houndoom", 354.00, "Crunch", "Flamethrower", "Tackle", "Shadown Ball", 306.00, 218.00, 317.00, "Dark", "Fire"};

        //AttackSuperEffective = {"Normal":[], "Fire":['Grass', 'Ice', 'Bug', 'Steel'], 'Water':['Fire', 'Ground', 'Rock'], 'Electric':['Water', 'Flying'], 'Grass':['Water', 'Ground', 'Rock'], 'Ice':['Grass', 'Ground', 'Flying', 'Dragon'], 'Fighting':['Normal', 'Ice', 'Rock', 'Dark', 'Steel'], 'Poison':['Grass'], 'Ground':['Fire', 'Electric', 'Poison', 'Rock', 'Steel'], 'Flying':['Grass', 'Fighting', 'Bug'], 'Psychic':['Fighting', 'Poison'], 'Bug':['Grass', 'Psychic', 'Dark'], 'Rock':['Fire', 'Ice', 'Flying', 'Bug'], 'Ghost':['Psychic', 'Ghost'], 'Dragon':['Dragon'], 'Dark':['Psychic','Ghost'], 'Steel':['Ice', 'Rock']}
        AttackSuperEffective["Normal"] = new List<string> {};
        AttackSuperEffective["Fire"] = new List<string> {"Grass", "Ice", "Bug", "Steel"};
        AttackSuperEffective["Water"] = new List<string> {"Fire", "Ground", "Rock"};
        AttackSuperEffective["Electric"] = new List<string> {"Water", "Flying"};
        AttackSuperEffective["Grass"] = new List<string> {"Water", "Ground", "Rock"};
        AttackSuperEffective["Ice"] = new List<string> {"Grass", "Ground", "Flying", "Dragon"};
        AttackSuperEffective["Fighting"] = new List<string> {"Normal", "Ice", "Rock", "Dark", "Steel"};
        AttackSuperEffective["Poison"] = new List<string> {"Grass"};
        AttackSuperEffective["Ground"] = new List<string> {"Fire", "Electric", "Poison", "Rock", "Steel"};
        AttackSuperEffective["Flying"] = new List<string> {"Grass", "Fighting", "Bug"};
        AttackSuperEffective["Psychic"] = new List<string> {"Fighting", "Poison"};
        AttackSuperEffective["Bug"] = new List<string> {"Grass", "Psychic", "Dark"};
        AttackSuperEffective["Rock"] = new List<string> {"Fire", "Ice", "Flying", "Bug"};
        AttackSuperEffective["Ghost"] = new List<string> {"Psychic", "Ghost"};
        AttackSuperEffective["Dragon"] = new List<string> {"Dragon"};
        AttackSuperEffective["Dark"] = new List<string> {"Psychic", "Ghost"};
        AttackSuperEffective["Steel"] = new List<string> {"Ice", "Rock"};

        //AttackIneffective = {"Normal":['Rock', 'Steel'], "Fire":["Fire",'Water', 'Rock', 'Dragon'], 'Water':['Water', 'Grass', 'Dragon'], 'Electric':['Electric', 'Grass', 'Dragon'], 'Grass':['Fire', 'Grass', 'Poison', 'Flying', 'Bug', 'Dragon', 'Steel'], 'Ice':['Ice', 'Fire', 'Water', 'Steel'], 'Fighting':['Poison', 'Flying', 'Psychic', 'Bug'],'Poison':['Poison', 'Ground', 'Rock', 'Ghost'],'Ground':['Grass', 'Bug'],'Flying':['Electric', 'Rock', 'Steel'], 'Psychic':['Psychic', 'Steel'], 'Bug':['Fire', 'Fighting', 'Poison', 'Flying', 'Ghost'], 'Rock':['Fighting', 'Ground', 'Steel'], 'Ghost':['Dark'], 'Dragon':['Steel'], 'Dark':['Fighting', 'Dark'], 'Steel':['Fire', 'Water', 'Electric', 'Steel']}
        AttackIneffective["Normal"] = new List<string> {"Rock", "Steel"};
        AttackIneffective["Fire"] = new List<string> {"Fire", "Water", "Rock", "Dragon"};
        AttackIneffective["Water"] = new List<string> {"Water", "Grass", "Dragon"};
        AttackIneffective["Electric"] = new List<string> {"Electric", "Grass", "Dragon"};
        AttackIneffective["Grass"] = new List<string> {"Fire", "Grass", "Poison", "Flying", "Bug", "Dragon", "Steel"};
        AttackIneffective["Ice"] = new List<string> {"Ice", "Fire", "Water", "Steel"};
        AttackIneffective["Fighting"] = new List<string> {"Poison", "Flying", "Psychic", "Bug"};
        AttackIneffective["Poison"] = new List<string> {"Poison", "Ground", "Rock", "Ghost"};
        AttackIneffective["Ground"] = new List<string> {"Grass", "Bug"};
        AttackIneffective["Flying"] = new List<string> {"Electric", "Rock", "Steel"};
        AttackIneffective["Psychic"] = new List<string> {"Psychic", "Steel"};
        AttackIneffective["Bug"] = new List<string> {"Fire", "Fighting", "Poison", "Flying", "Ghost"};
        AttackIneffective["Rock"] = new List<string> {"Fighting", "Ground", "Steel"};
        AttackIneffective["Ghost"] = new List<string> {"Dark"};
        AttackIneffective["Dragon"] = new List<string> {"Steel"};
        AttackIneffective["Dark"] = new List<string> {"Fighting", "Dark"};
        AttackIneffective["Steel"] = new List<string> {"Fire", "Water", "Electric", "Steel"};

        //AttackNull = {"Normal":['Ghost'], "Fire":[], 'Water':[], 'Electric':['Ground'], 'Grass':[], 'Ice':[], 'Fighting':['Ghost'], 'Poison':['Steel'], 'Ground':['Flying'], 'Flying':[], 'Psychic':['Dark'], 'Bug':[], 'Rock':[], 'Ghost':['Normal'], 'Dragon':[], 'Dark':[], 'Steel':[]}
        AttackNull["Normal"] = new List<string> {"Ghost"};
        AttackNull["Fire"] = new List<string> {};
        AttackNull["Water"] = new List<string> {};
        AttackNull["Electric"] = new List<string> {"Ground"};
        AttackNull["Grass"] = new List<string> {};
        AttackNull["Ice"] = new List<string> {};
        AttackNull["Fighting"] = new List<string> {"Ghost"};
        AttackNull["Poison"] = new List<string> {"Steel"};
        AttackNull["Ground"] = new List<string> {"Flying"};
        AttackNull["Flying"] = new List<string> {};
        AttackNull["Psychic"] = new List<string> {"Dark"};
        AttackNull["Bug"] = new List<string> {};
        AttackNull["Rock"] = new List<string> {};
        AttackNull["Ghost"] = new List<string> {"Normal"};
        AttackNull["Dragon"] = new List<string> {};
        AttackNull["Dark"] = new List<string> {};
        AttackNull["Steel"] = new List<string> {};
    }

    public static float calculateDamage(Pokemon attacker, Pokemon target, Move move) {
        float modifier = 1;

        if (AttackNull[move.type].Contains(target.type1) || AttackNull[move.type].Contains(target.type2)) {
            //Console.WriteLine(move.name + ": Null");
            return 0;
        }

        if (attacker.type1 == move.type || attacker.type2 == move.type) {
            modifier *= 1.5f; // Same Type Attack 
            //Console.WriteLine(move.name + ": STAB");
        }

        if (AttackSuperEffective[move.type].Contains(target.type1)) {
            modifier *= 2.0f;
            //Console.WriteLine(move.type + " super effective against " + target.type1);
        }

        if (AttackSuperEffective[move.type].Contains(target.type2)) {
            modifier *= 2.0f;
            //Console.WriteLine(move.type + " super effective against " + target.type2);
        }

        if (AttackIneffective[move.type].Contains(target.type1)) {
            modifier *= 0.5f;
            //Console.WriteLine(move.type + " ineffective against " + target.type1);
        }

        if (AttackIneffective[move.type].Contains(target.type2)) {
            modifier *= 0.5f;
            //Console.WriteLine(move.type + " ineffective against " + target.type2);
        }
        
        float damage = ((0.84f*move.power*(attacker.attack/target.defense)) + 2.0f)*modifier;

        return damage;
    }
}