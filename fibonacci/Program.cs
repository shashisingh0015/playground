Console.WriteLine("Fibonacci series up to:");
int n = Convert.ToInt32(Console.ReadLine());

int a = 0, b = 1, next;

Console.WriteLine("Fibonacci series:");
for (int i = 0; i < n; i++)
{
    Console.Write(a + " ");
    next = a + b;
    a = b;
    b = next;
}