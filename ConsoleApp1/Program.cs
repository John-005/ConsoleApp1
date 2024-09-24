

using System.ComponentModel.Design;

float hunger = 25f;
float full = 30f;
int money = 50;
string choice;
float time = 0;

// Game start
Console.WriteLine($"Cash on hand {money}");
Console.WriteLine("Location town of Alberta");
Console.WriteLine("optian a car 1");
Console.WriteLine("option b car 2");
Console.WriteLine("optian c bus");
Console.WriteLine("which do you choose");
choice=Console.ReadLine();

// Optian a code block
if (choice == "optian a") {
    time++;
    Console.WriteLine($"time change to noon");
    hunger -= 5;
    Console.WriteLine($"do you want to buy food to fill hunger? {hunger} out of {full}");
    choice = Console.ReadLine();
    if (choice== "yes") {
        Console.WriteLine("buy snack");
 money -= 3;
        Console.WriteLine($"remaining cash {money}");
    } 
    else if (choice=="no") { Console.WriteLine("you go hungry"); }
    time++;
    Console.WriteLine("get ride to outskirts of berta");
    time++;
    Console.WriteLine("After getting dropped off walk along road");
    Console.WriteLine("you got bit by a posionus snake and died. ending 1/4");
}

// Optian b code block
else if (choice == "optian b") {
    time++;
    Console.WriteLine("get ride and go to berta bus station");
    Console.WriteLine("take bus to motel");
    money -= 5;
    time++;
    Console.WriteLine($"remaining cash {money}");
    Console.WriteLine("get motel room for the night");
    money -= 30;
    Console.WriteLine($"remaining cash {money}");
    time++;
    Console.WriteLine("You slept safely at the motel. ending 2/4");
}

// Optian c code block
else if (choice == "optian c")
{ Console.WriteLine("take bus to hamilton bus station");
money -= 5;
    Console.WriteLine($"remaining cash {money}");
    Console.WriteLine("catch ride to hamilton bus station for the night");
    Console.WriteLine("You fall asleep in a chair only to wake up to see that you got robbed for everything. ending 3/4");
money -= 45;
    Console.WriteLine($"remaining cash {money}");
}

// Fallback code block
else { Console.WriteLine("you got human traffcked good job");
    Console.WriteLine($"do you want to attempt to escape");
    choice= Console.ReadLine();
    if (choice=="yes")
        Console.WriteLine("you escape but are in the middle of nowhere and end up dying of hunger");
    else if (choice=="no")
        Console.WriteLine("the traffickers send you to a new family in norway and you live happy");
    Console.WriteLine("ending 4/4");
    Console.WriteLine("secret ending");
}
