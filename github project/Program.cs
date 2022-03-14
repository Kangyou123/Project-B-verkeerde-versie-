





Console.WriteLine("Enter age:");
string value;
int Age;
value = Console.ReadLine();
Age = Convert.ToInt32(value);

if (Age >= 16)
{
    Console.WriteLine("Ur old enough to make an account");
}
else
{
    Console.WriteLine("Ur too young to make an account");
}
