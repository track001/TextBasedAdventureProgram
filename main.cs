using System;
using System.Threading;

class Program
{

    static void Main()
    {
        bool hasKey = false;
        bool hasPig = false;
        bool hasMoney = false;
        bool hasBoughtDrink = false;
        bool hasPonderedCountryside = false;

        Console.WriteLine("Welcome to Ti's Text Based Adventure Game!");
        // Pause the program execution for 1 second
        Thread.Sleep(1000);

        Console.WriteLine("You are in a magical land - dangerous, but magical.");
        // Pause the program execution for 1 second
        Thread.Sleep(1000);

        Console.WriteLine("You heard a rumor that there is treasure in this region and you want to find it.");
        // Pause the program execution for 1 second
        Thread.Sleep(1000);

        // Pause the program execution for 1 second
        Thread.Sleep(1000);
        while (true)
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Look around.");
            Console.WriteLine("2. Open the door.");
            Console.WriteLine("3. Go to the pub.");
            Console.WriteLine("4. Ponder the countryside.");
            Console.WriteLine("5. Quit the game.");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("You are in a beautiful medieval world with lush trees, cute little woodland creatures, and beautiful flowing streams.");
                if (hasKey)
                {
                    Console.WriteLine("You already took the key off the table. You're just grabbing at air.");

                    // Pause the program execution for 1 second
                    Thread.Sleep(1000);
                    Console.WriteLine("Stop being silly! There's a quest at hand!");
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
                Console.WriteLine("\nYou squint, the hole looks dragon shaped. ");

                // Pause the program execution for 3 seconds
                Thread.Sleep(3000);
                Console.WriteLine("A terrible and powerful dragon is guarding the treasure chest.");
                if (!hasPig)
                {
                    Console.WriteLine("You need to sacrifice something in order to pass.");
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Fight the dragon and almost certainly die.");
                    Console.WriteLine("2. Run away like the hero you are.");

                    string doorChoice = Console.ReadLine();
                    if (doorChoice == "1")
                    {
                        Console.WriteLine("You try to fight the dragon...");
                        // Pause the program execution for 2 seconds
                        Thread.Sleep(2000);
                        Console.WriteLine("But without something to sacrifice, you are easily overpowered.");
                        // Pause the program execution for 3 seconds
                        Thread.Sleep(3000);
                        Console.WriteLine("You die after being burnt to a crisp and then gnawed on.");
                        // Pause the program execution for 3 seconds
                        Thread.Sleep(3000);
                        Console.WriteLine("The dragon finds your attempt amusing and is laughing while eating you.");
                        break;
                    }
                    else if (doorChoice == "2")
                    {
                        Console.WriteLine("\nYou run away from the dragon and salvage your heroism - or so you'll tell the villagers if they ask...");

                        // Pause the program execution for 3 seconds
                        Thread.Sleep(3000);
                        Console.WriteLine("You tell them that you fought the dragon and barely got away with your life.");

                        // Pause the program execution for 3 seconds
                        Thread.Sleep(3000);
                        Console.WriteLine("They don't believe you, they mock you.");

                        // Pause the program execution for 3 seconds
                        Thread.Sleep(3000);
                        Console.WriteLine("You die from a tomato allergy because they won't stop throwing them at you as you walk past them with great embarrassment. ");

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
                    Console.WriteLine("1. Fight the dragon with your bare knuckles, a gentlemen's fisticuffs if you will.");
                    Console.WriteLine("2. Run away back to the main path.");
                    Console.WriteLine("3. Heroically sacrifice the pig and sneak by the dragon while he munches.");

                    string doorChoice = Console.ReadLine();
                    if (doorChoice == "1")
                    {
                        Console.WriteLine("You try to fight the dragon, but it overpowers you and you die immediately, didn't even last 5 seconds.");
                        Console.WriteLine("Dragons don't need fists, they have fire you dumbass.");
                        break;
                    }
                    else if (doorChoice == "2")
                    {
                        Console.WriteLine("You run away from the dragon and ponder your patheticism... you wonder if you should just be a pig farmer like your friend and consider joining the Pig Farmers Association.");
                        break;
                    }
                    else if (doorChoice == "3")
                    {
                        Console.WriteLine("You heroically sacrifice the pig and sneak by the dragon!");
                        Console.WriteLine("You temporarily feel bad, but justify it. If the pig was a beer-producing pig, he would've lived. After all, why should cows produce all the beverages?");
                        Console.WriteLine("Good for nothing pige, you think to yourself.");

                        if (hasKey)
                        {
                            Console.WriteLine("You use the key to open the treasure chest and find the legendary treasure!");
                            Console.WriteLine(" It's a coupon to a one year membership for joining the Pig Farmer's Association! You sigh.");
                            Console.WriteLine("You sigh in dissapointement and hold your arms out to the dragon and tell him you're ready now.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You don't have the key to unlock the chest. You're trapped and the dragon turns on you, having finished his pig appetizer");
                            Console.WriteLine("He flames you until you are a delicated medium rare, and devours you. But not after adding a little caviar he was saving for a special, human-centered entrée moment.");
                            Console.WriteLine("You use the key to open the treasure chest and find the legendary treasure!");
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
                if (hasMoney)
                {
                    Console.WriteLine("1. Buy a beer for the farmer.");
                    Console.WriteLine("2. Buy a drink for yourself.");
                }
                else
                {
                    Console.WriteLine("1. Listen to the farmer's complaint.");
                    Console.WriteLine("2. Listen to the bartender's complaint.");
                }

                string drinkChoice = Console.ReadLine();
                if (hasMoney)
                {
                    if (drinkChoice == "1")
                    {
                        if (hasBoughtDrink)
                        {
                            Console.WriteLine("\nYou already bought a drink for yourself. The bartender yells at you for trying to buy another one because you have $0 now.");
                            Console.WriteLine("You retort and yell that $10 is too damn much for one beer.");
                            Console.WriteLine("You pissed the bartender off... he summons the village council, and they sentence you to death.");
                            Console.WriteLine("\nNext time maybe don't piss the bartender off?");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You buy a beer for the farmer.");
                            Console.WriteLine("The farmer drunkenly asks if you want to see his pig farm. Do you want to? (yes/no)");
                            string farmChoice = Console.ReadLine();
                            if (farmChoice.ToLower() == "yes")
                            {
                                Console.WriteLine("\nYou visit the farmer's pig farm.");
                                Console.WriteLine("The farmer is so drunk and happy from his beer that he gives you a pig for free as a trade for your friendliness.");
                                hasPig = true;
                            }
                            else if (farmChoice.ToLower() == "no")
                            {
                                Console.WriteLine("\nThe farmer drunkenly stabs you in anger. He doesn't like that you look down on his pig farming lifestyle.");
                                Console.WriteLine("You're not better than him, do you even have a day job??");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid input. Please try again.");
                            }
                        }
                    }
                    else if (drinkChoice == "2")
                    {
                        Console.WriteLine("\nYou buy a drink for yourself. Nothing like a nice cold beer, $10 might I add. Steep!");
                        hasBoughtDrink = true;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input. Please try again.");
                    }
                }
                else
                {
                    if (drinkChoice == "1")
                    {
                        Console.WriteLine("\nThe farmer complains about how many fat pigs he has and how badly he wants to drink a beer.");
                        // Pause the program execution for 3 seconds
                        Thread.Sleep(3000);
                        Console.WriteLine("You think about how you read somewhere that dragons like pigs.");
                        // Pause the program execution for 2 seconds
                        Thread.Sleep(2000);
                        Console.WriteLine("You also consider your lack of money and feel immense shame.");
                    }
                    else if (drinkChoice == "2")
                    {
                        Console.WriteLine("\nThe bartender complains about people who can't pay for the drinks they order.");
                        // Pause the program execution for 2 seconds
                        Thread.Sleep(2000);
                        Console.WriteLine(" And how much the Pig Farmer's Association annoys him.");
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input. Please try again.");
                    }
                }
            }
            else if (input == "4")
            {
                if (hasPonderedCountryside)
                {
                    Console.WriteLine("\nYou've already pondered the countryside. More pondering will not earn you more money. Stop being greedy.");
                    // Pause the program execution for 2 seconds
                    Thread.Sleep(2000);
                    Console.WriteLine("Stop being greedy.");
                }
                else
                {
                    Console.WriteLine("You ponder the countryside, trying to find ways to earn some money...");
                    Console.WriteLine("You see a band of bunnies on the side of the road as well as a stack of gold.");
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Slay the bunnies and sell their pelts.");
                    Console.WriteLine("2. Pick up the gold.");

                    string countrysideChoice = Console.ReadLine();
                    if (countrysideChoice == "1")
                    {
                        Console.WriteLine("\nYou slay the bunnies and sell their pelts. You earn $10!");
                        hasMoney = true;
                        hasPonderedCountryside = true;
                    }
                    else if (countrysideChoice == "2")
                    {
                        Console.WriteLine("\nA fairy appears and tells you that gold is useless in this region, and they may as well be paperweights.");
                        Console.WriteLine("You sigh. Go figure. May as well get some free paperweights.");
                        // Pause the program execution for 3 seconds
                        Thread.Sleep(3000);
                        Console.WriteLine("You pocket them and you're about to carry on your journey when suddenly...");

                        // Pause the program execution for 4 seconds
                        Thread.Sleep(4000);

                        Console.WriteLine("\nA mischievous leprechaun appears in a flash of light.");
                        Console.WriteLine("He exclaims, 'Those are my beloved paperweights! How dare you steal them!' and shoots you with 3 unicorn horns to the heart.");
                        Console.WriteLine("You collapse to the ground, gasping for breath, as the leprechaun disappears, laughing maniacally.");
                        // Pause the program execution for 1 second
                        Thread.Sleep(1000);
                        Console.WriteLine("\nTLDR: Leprechauns take their paperwights way too seriously.");
                        break;
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

        Console.WriteLine("\nGame over. Would you like to try again? (yes/no)");
        string playAgain = Console.ReadLine();
        if (playAgain.ToLower() == "yes")
        {
            Main();
        }
    }
}
