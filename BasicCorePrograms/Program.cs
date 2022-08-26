using BasicCorePrograms;
Console.WriteLine("Welcome to basic core program");
while (true)
{
    Console.WriteLine("\nSelect program\n 1.Flip Coin\n 2.Leap Year");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            FlipCoin.FlipCoinPercentage();
            break;
        case 2:
            LeapYear.Yearmethod();
            break;
        default:
            Console.WriteLine("Select correct option");
            break;
    }
}

