Random rnd= new Random();
int cpuRand;
bool loopActive = true;
while (loopActive)
{
    cpuRand = rnd.Next(1, 4);
    //Console.WriteLine($"cpu generated {cpuRand}");
    Console.WriteLine("Guess the number (1-3)");
    int userNumb = Int32.Parse(Console.ReadLine());
    if (userNumb == cpuRand)
    {
        Console.WriteLine("Congratulations, you've won!");
        //loopActive = false;
        break;
    }
    else
    {
        Console.WriteLine("Wrong, try again!");
    }

}
Console.WriteLine("Have a nice day!");