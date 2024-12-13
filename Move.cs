namespace PokeCLI.Move;

class Move {
    public string name, type, statChange; 
    public int accuracy, pp, power, attInc, defInc, speedInc, hpInc;
    public Move(string name, int accuracy, string type, int pp, int power=0, int attInc=0, int defInc=0, int speedInc=0, int hpInc=0, string statChange="") {
        this.name = name;
        this.accuracy = accuracy;
        this.type = type;
        this.pp = pp;
        this.power = power;
        this.attInc = attInc;
        this.defInc = defInc;
        this.speedInc = speedInc;
        this.hpInc = hpInc;
        this.statChange = statChange;        
    }
}