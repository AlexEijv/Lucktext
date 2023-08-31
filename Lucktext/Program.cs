
Console.ForegroundColor = ConsoleColor.Blue;
Console.BackgroundColor = ConsoleColor.Red;
Console.Clear();


string name = "";

string favoritegame = "";

string favoritedrink = "";

Console.WriteLine("Hello my friend, what's your name?");
name = Console.ReadLine();

Console.WriteLine("Tell me friend, what is your favorite game?");
favoritegame = Console.ReadLine();

Console.WriteLine("And now friend, tell me what your favorite drink is");
favoritedrink = Console.ReadLine();



Console.WriteLine($"How is {favoritegame} your favorite game? {name} you really need help");

Console.WriteLine($"And how can you even drink {favoritedrink} without throwing up?");

Console.WriteLine("Press enter to quit");
Console.ReadLine();