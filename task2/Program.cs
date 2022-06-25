int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int x = Convert.ToInt32(0);
if (a > b) x = a;
else x = b;
if (c > x) x = c;
else Console.Write ("max = ");
Console.Write (x);