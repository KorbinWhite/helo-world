// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.InteropServices;


int theManticore = 10;
int cityOfConsolas = 15;
int placementBeginning;
int placement;
int damage;
int roundNumber = 1;



Console.WriteLine("Player 1, Choose the Manticore's distance, 1 - 100");
placementBeginning = Convert.ToInt32((Console.ReadLine()));
GameStart();

void GameStart()
{
    for (roundNumber = 1; theManticore > 0 || cityOfConsolas > 0; roundNumber++)
    {
        Console.Clear();
        Console.WriteLine($"Round: {roundNumber}\t City:{cityOfConsolas} \t Manticore:{theManticore}");
        if (roundNumber % 3 == 0 && roundNumber % 5 == 0)
        {
            damage = 15;
            Console.WriteLine($"The damage for this round is worth {damage} points");
        }
        else if (roundNumber % 5 == 0)
        {
            damage = 5;
            Console.WriteLine($"The damage for this round is worth {damage} points");
        }
        else if (roundNumber % 3 == 0)
        {
            damage = 3;
            Console.WriteLine($"The damage for this round is worth {damage} points");
        }

        else
        {
            damage = 1;
            Console.WriteLine($"The damage for this round is worth {damage} points");
        }
        Console.WriteLine("Enter the disired cannon range");
        placement = Convert.ToInt32(Console.ReadLine());
        if (placement == placementBeginning)
        {
            Console.WriteLine("A DIRECT HIT");
            theManticore--;
        }
        else if (placement > placementBeginning)
        {
            Console.WriteLine("You overshot your shot, now the Manticore deal 1 damage to the city");
            cityOfConsolas--;
        }
        else if (placement < placementBeginning)
        {
            Console.WriteLine("You undershot your shot, now the Manticore deal 1 damage to the city");
            cityOfConsolas--;
        }
    }
if (theManticore == 0)
        {
            Console.WriteLine("The manticore has been destroyed! The city of Consolas has been saved!");
        }
else if (cityOfConsolas == 0)
        {
            Console.WriteLine("The city of Consolas has been destroyed! The Aliens have taken over the city!");
        }
    


}

