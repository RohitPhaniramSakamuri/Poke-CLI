using PokeCLI.Agent;
using PokeCLI.GameConstants;
using PokeCLI.Player;
using PokeCLI.Pokemon;
using Spectre.Console;

Player user = new Player("You");
Agent pc = new Agent("Sakamuri");

// Don't forget to add Swampert to this list
string[] list = { "Swampert", "Blastoise", "Pikachu", "Charizard", "Tyranitar", "Gengar", 
    "Venusaur", "Snorlax", "Dragonite", "Mewtwo", "Rayquaza", "Blaziken", 
    "Sceptile", "Heracross", "Articuno", "Metagross", "Houndoom" };

// Create a layout for the application
var layout = new Layout("Root")
    .SplitColumns(
        new Layout("Left"),
        new Layout("Right")
            .SplitRows(
                new Layout("Top"),
                new Layout("Bottom")));

// Display a MultiSelectionPrompt within the right top panel
var choices = AnsiConsole.Prompt(
    new MultiSelectionPrompt<string>()
        .Title("Choose your [red]Pokemon[/]!")
        .Required()
        .PageSize(10)
        .MoreChoicesText("[grey](Move up and down to reveal more Pokemon!)[/]")
        .InstructionsText(
            "[grey](Press [blue]<space>[/] to toggle a Pokemon, " +
            "[green]<enter>[/] to accept)[/]")
        .AddChoices(list)
);

// Update the left panel to display the selected team
layout["Left"].Update(
    new Panel(
        Align.Center(
            new Markup("[green]Your Selected Team:[/]"), 
            VerticalAlignment.Top)
        )
    .Expand());

var teamPanel = new Panel("Your Team")
    .Expand()
    .Header("[purple]Team Roster[/]");

foreach (string pokemon in choices) {
    // Add the Pokémon to the user's team
    user.addToTeam(pokemon);

    // Search for the Pokémon in the list and remove it
    int i = 0;
    while (i < list.Length && list[i] != pokemon)
    {
        i++;
    }

    if (i < list.Length)
    {
        list[i] = "";
    }

    // Add the Pokémon to the team panel
    //teamPanel.AddContent(new Markup($"[blue]{pokemon}[/]"));
}

// Add the team panel to the left layout
layout["Left"].Update(teamPanel);

// Render the layout
AnsiConsole.Write(layout);

// Testing output
Console.WriteLine("Testing");

// Displaying list to ensure changes are tracked
foreach (string s in list)
{
    Console.WriteLine(s);
}

// Set up current Pokémon and attacks
user.setCurrentPoke(user.team[0]);
pc.curateTeam(list);
pc.showTeam();
pc.setCurrentPoke(pc.team[0]);

user.currentPoke.Attack(pc.currentPoke, user.currentPoke.moves[0]);
user.currentPoke.Attack(pc.currentPoke, user.currentPoke.moves[1]);
user.currentPoke.Attack(pc.currentPoke, user.currentPoke.moves[2]);
user.currentPoke.Attack(pc.currentPoke, user.currentPoke.moves[3]);
user.currentPoke.Attack(pc.currentPoke, user.currentPoke.moves[0]);
