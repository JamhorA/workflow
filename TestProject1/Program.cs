using TestProject1.Components;
using TestProject1.Models;

var minUser = new User();

int mittId = minUser.Id;

minUser.Name = "Johanna";

Dice myDice= new Dice();

int diceThrow = myDice.throwDice();
