Random rnd = new Random();
int myRandNum;
int randSum = 0;
for (int i = 0; i < 20; i++)
{
    myRandNum = rnd.Next(0, 100); //0-10
    randSum = randSum+ myRandNum;
    Console.WriteLine($"My randoom numeber is {myRandNum}.");
}
Console.WriteLine($"My random number total is {randSum}");