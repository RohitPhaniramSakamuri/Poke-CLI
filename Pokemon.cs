namespace PokeCLI.Pokemon;

using PokeCLI.Move;
using PokeCLI.GameConstants;
using System;
using System.Collections.Generic;

class Pokemon {
    public string name, type1, type2, status;
    public float hp, attack, defense, speed;
    public int moveCount;

    public Move[] moves = new Move[4];

    public Pokemon() {
        this.name = "";
        this.type1 = "";
        this.type2 = "";
        this.status = "";
        this.attack = 0;
        this.hp = 0;
        this.defense = 0;
        this.speed = 0;
        this.moveCount = 0;
    }

    public Pokemon(string name, float hp, string[] moveNames, float attack, float defense, float speed, string type1, string type2="", string status="") {
        this.name = name;
        this.hp = hp;
        this.attack = attack;
        this.defense = defense;
        this.speed = speed;
        this.type1 = type1;
        this.type2 = type2;
        this.status = status;
        this.moveCount = 0;

        foreach (string moveName in moveNames) {
            //string name, int accuracy, string type, int pp, int power=0, int attInc=0, int defInc=0, int speedInc=0, int hpInc=0, string statChange=""
            
            Dictionary<string, List<object>> moveData = GameConstants.moveData;
            
            this.moves[moveCount] = new Move(
                (string)moveData[moveName][0],       // moveName
                Convert.ToInt32(moveData[moveName][1]),  // accuracy
                (string)moveData[moveName][2],       // type
                Convert.ToInt32(moveData[moveName][3]),  // pp
                Convert.ToInt32(moveData[moveName][4]),  // power
                Convert.ToInt32(moveData[moveName][5]),  // attInc
                Convert.ToInt32(moveData[moveName][6]),  // defInc
                Convert.ToInt32(moveData[moveName][7]),  // speedInc
                Convert.ToInt32(moveData[moveName][8]),  // hpInc
                (string)moveData[moveName][9]        // statChange
            );
            this.moveCount++;
        }

    }

    public void Attack(Pokemon target, Move move) {
        Random generator = new Random();
        bool willHit = generator.Next(0, 101) <= move.accuracy;
        if (!willHit) {
            Console.WriteLine(this.name + "'s " + move.name + " missed!");
            return;
        } 
        if (move.pp <= 0) {
            Console.WriteLine(move.name + " does not have enough pp!");
            return;
        }

        target.hp -=  GameConstants.calculateDamage(this, target, move); //TODO these two lines of code need to be optimised
        Console.WriteLine(move.name + " did " + GameConstants.calculateDamage(this, target, move));
        target.handleStatus();
    }

    public void handleStatus() {
        if (this.hp < 0) {
            this.hp = 0;
            this.status = "fnt";
            Console.WriteLine(this.name + " fainted!");
        } else {
            //Console.WriteLine(this.name + ": " + this.hp);
        }
    }
}


