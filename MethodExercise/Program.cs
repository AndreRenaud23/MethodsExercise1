using System.Globalization;

Console.WriteLine("What is your name?");
var name = Console.ReadLine();
Console.WriteLine("--------------------------------------");
Console.WriteLine($"Hello, how are you doing {name}?");
var condition = Console.ReadLine();
Console.WriteLine("--------------------------------------");
Console.WriteLine("Ok...... how old are you?");
int age = Convert.ToInt32(Console.ReadLine());
if (age <= 125)
    Console.WriteLine("That is a good age to be");
else
    Console.WriteLine("Woah....... your different!");
Console.WriteLine("--------------------------------------");
if (age <= 20)
{
    Console.WriteLine($"What is your favorite type of video game console {age} year old {name}? ONLY ONE!");
    var videoGameConsole = Console.ReadLine();
}
else if (age > 125)
{
    Console.WriteLine($"Are you actually {age} years old? Put in your real age.......");
    int Age1 = Convert.ToInt32(Console.ReadLine());
    if (Age1 > 125)
    {   
        
        Console.WriteLine($"Ok... sorry for questioning your intelligence {name}.... but.....");
        Console.WriteLine($"No one is that old... put in your real age:");
        int age2 = Convert.ToInt32(Console.ReadLine());
        while (age2 > 125)
        {
            if (age2 <= 125)
            {
                break;
            }
            else
            {
                Console.WriteLine("Sorry.... but thats impossible!!!!!!!!!!!!");
                Console.WriteLine($"No one is that old... put in your real age:");
                age2 = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    else
    {
        Console.WriteLine("Hah! I thought so!");
    }
}
else
{
    Console.WriteLine($"What is your job {name}?");
    var job = Console.ReadLine();
}

Console.WriteLine("--------------------------------------");
Console.WriteLine("Hmmm...... thats acceptable...");
Console.WriteLine("--------------------------------------");
Console.WriteLine("What is your favorite type of tree? ONLY ONE! (Press enter to skip)");
var tree = Console.ReadLine();
Console.WriteLine("--------------------------------------");
Console.WriteLine($"{tree}.....? I haven't heard of that one before....");
Console.WriteLine("--------------------------------------");
Console.WriteLine("Wow..... your good at this.... I guess I can let you go now :)");
Console.WriteLine("--------------------------------------");
Console.WriteLine($"Press enter to confirm");
var info = Console.ReadLine();
Console.WriteLine("--------------------------------------");
Console.WriteLine($"Are you SURE you would like to continue? (yes/no)");
var confirm = Console.ReadLine();
Console.WriteLine($"Something happened! Something is not right...... would you really want to continue? (yes/no)");
var confirm2 = Console.ReadLine();
Console.WriteLine($"System failure...... Press enter.....");
var confirm3 = Console.ReadLine();
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("-----------------------------------!COMPUTER INFORMATION STOLEN! PROGRESS: 100%-----------------------------------");
Console.WriteLine("-------------------------------Thanks for letting me suck up your information! :) Bye!----------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");






