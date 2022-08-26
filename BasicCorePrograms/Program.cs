using BasicCorePrograms;
Console.WriteLine("Welcome to basic core program");
while (true)
{
    Console.WriteLine("\nSelect program\n 1.Flip Coin\n 2.Leap Year\n 3.Power of 2\n 4.Harmonic Number\n 5.Factors\n 6.QuotientRemainder\n 7.Swap Numbers\n 8.Even or Odd");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            FlipCoin.FlipCoinPercentage();
            break;
        case 2:
            LeapYear.Yearmethod();
            break;
        case 3:
            PowerOf2.PowerOf2Method();
            break;
        case 4:
            HarmonicNumber.HarmonicNumberMmethod();
            break;
        case 5:
            Factor.FactorMethod();
            break;
        case 6:
            QuotientRemainder.QuotientandRemainder();
            break;
        case 7:
            SwapNumbers.SwapMethod();
            break;
        case 8:
            EvenOdd.EvenOrOdd();
            break;
        default:
            Console.WriteLine("Select correct option");
            break;
    }
}

