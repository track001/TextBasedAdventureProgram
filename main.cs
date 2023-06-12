using System;

class Program
{
    static void Main()
    {
        bool hasKey = false;
        bool hasPig = false;
        bool hasMoney = false;
        bool hasBoughtDrink = false;
        bool hasPonderedCountryside = false;

        while (true)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Look around");
            Console.WriteLine("2. Open the door");
            Console.WriteLine("3. Go to the pub");
            Console.WriteLine("4. Ponder the countryside");
            Console.WriteLine("5. Quit the game");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("You are in a beautiful medieval world with lush trees and flowing streams.");
                if (hasKey)
                {
                    Console.WriteLine("You already took the key off the table. You're just grabbing at air.");
                }
                else
                {
                    Console.WriteLine("You see a table with a key on it. Do you take it or leave it? (take/leave)");
                    string tableChoice = Console.ReadLine();
                    if (tableChoice.ToLower() == "take")
                    {
                        Console.WriteLine("You take the key.");
                        hasKey = true;
                    }
                    else if (tableChoice.ToLower() == "leave")
                    {
                        Console.WriteLine("You leave the key on the table.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                    }
                }
            }
            else if (input == "2")
            {
                Console.WriteLine("The dragon is guarding the treasure chest.");
                if (!hasPig)
                {
                    Console.WriteLine("You need to sacrifice something in order to pass.");
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Fight the dragon");
                    Console.WriteLine("2. Run away");

                    string doorChoice = Console.ReadLine();
                    if (doorChoice == "1")
                    {
                        Console.WriteLine("You try to fight the dragon, but without the pig to sacrifice, you are overpowered and die.");
                        break;
                    }
                    else if (doorChoice == "2")
                    {
                        Console.WriteLine("You run away from the dragon and abandon your quest.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Fight the dragon");
                    Console.WriteLine("2. Run away");
                    Console.WriteLine("3. Heroically sacrifice the pig and sneak by the dragon");

                    string doorChoice = Console.ReadLine();
                    if (doorChoice == "1")
                    {
                        Console.WriteLine("You try to fight the dragon, but it overpowers you and you die.");
                        break;
                    }
                    else if (doorChoice == "2")
                    {
                        Console.WriteLine("You run away from the dragon and abandon your quest.");
                        break;
                    }
                    else if (doorChoice == "3")
                    {
                        Console.WriteLine("You heroically sacrifice the pig and sneak by the dragon.");

                        if (hasKey)
                        {
                            Console.WriteLine("You use the key to open the treasure chest and find the legendary treasure!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You don't have the key to unlock the chest. You're trapped!");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                    }
                }
            }
            else if (input == "3")
            {
                Console.WriteLine("You decide to go to the pub.");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Buy a beer for the farmer");
                Console.WriteLine("2. Buy a drink for yourself");

                string drinkChoice = Console.ReadLine();
                if (drinkChoice == "1")
                {
                    if (hasBoughtDrink)
                    {
                        Console.WriteLine("You already bought a drink for yourself. The bartender yells at you for trying to buy another one because you have $0.");
                        Console.WriteLine("You retort and yell that $10 is too damn much for one beer.");
                        Console.WriteLine("You pissed the bartender off... he summons the village council, and they sentence you to death.");
                        Console.WriteLine("Game over.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You buy a beer for the farmer.");
                        Console.WriteLine("The farmer asks if you want to see his pig farm. Do you want to? (yes/no)");
                        string farmChoice = Console.ReadLine();
                        if (farmChoice.ToLower() == "yes")
                        {
                            Console.WriteLine("You visit the farmer's pig farm.");
                            Console.WriteLine("The farmer is so drunk that he gives you a pig for free as a trade for the beer.");
                            hasPig = true;
                        }
                        else if (farmChoice.ToLower() == "no")
                        {
                            Console.WriteLine("The farmer drunkenly stabs you in anger.");
                            Console.WriteLine("Game over.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please try again.");
                        }
                    }
                }
                else if (drinkChoice == "2")
                {
                    Console.WriteLine("You buy a drink for yourself.");
                    hasBoughtDrink = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            else if (input == "4")
            {
                if (hasPonderedCountryside)
                {
                    Console.WriteLine("You've already pondered the countryside. More pondering will not earn you more money.");
                }
                else
                {
                    Console.WriteLine("You ponder the countryside, trying to earn money...");
                    Console.WriteLine("You see a band of bunnies and a stack of gold.");
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Slay the bunnies and sell their pelts");
                    Console.WriteLine("2. Pick up the gold");

                    string countrysideChoice = Console.ReadLine();
                    if (countrysideChoice == "1")
                    {
                        Console.WriteLine("You slay the bunnies and sell their pelts. You earn $10.");
                        hasMoney = true;
                        hasPonderedCountryside = true;
                    }
                    else if (countrysideChoice == "2")
                    {
                        Console.WriteLine("You pick up the gold, but it has no monetary value in this region.");
                        hasPonderedCountryside = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                    }
                }
            }
            else if (input == "5")
            {
                Console.WriteLine("Quitting the game...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }

        Console.WriteLine("Game over. Would you like to try again? (yes/no)");
        string playAgain = Console.ReadLine();
        if (playAgain.ToLower() == "yes")
        {
            Main();
        }
    }
}
