Console.WriteLine("Enter the number:");
int number = Convert.ToInt32(Console.ReadLine());

if (isPrime(number))
{
    Console.WriteLine("{0} is prime.", number);
}
else
{
    Console.WriteLine("{0} is not prime.", number);
}

bool isPrime(int num)
{
    if (num <= 1)
        return false;

    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0) {
            return false;
        }
    }
    return true;
}