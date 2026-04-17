Console.WriteLine(@"
______________.___.________________________________________   ___ ___    ________________
\_   ___ \__  |   |\______   \_   _____/\______   \_   ___ \ /   |   \  /  _  \__    ___/
/    \  \//   |   | |    |  _/|    __)_  |       _/    \  \//    ~    \/  /_\  \|    |   
\     \___\____   | |    |   \|        \ |    |   \     \___\    Y    /    |    \    |   
 \______  / ______| |______  /_______  / |____|_  /\______  /\___|_  /\____|__  /____|   
        \/\/               \/        \/         \/        \/       \/         \/         
                                                                                         
");

Console.Write(" Please enter your Name: ");
string Name = Console.ReadLine();

Console.WriteLine(" Hello" + Name + "!Welcome to the cybersecority bot.");

String input = Console.ReadLine().ToLower();

if (input == "How are you?")
{
    console.WriteLine("Sorry! but i'm just a bot here to assist you with cybersecurity matters, so have no feelings");
}
else if (input.Contains("password"))
{
    Console.WriteLine("Sorry but your password is not strong enough. Please use stronger password, try mixibn letters, numbers and special characters");
}
else if (input.Contains("Randsomware"))
{
     Console.WriteLine("This refers to the type of malware that locks your files and demands payment to unlock them.Think of it as a digital kidnapper for all your documents");
} 
else
{
    Console.WriteLine("I didn't quit get that please try again!");
}
if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Please enter something!");
}