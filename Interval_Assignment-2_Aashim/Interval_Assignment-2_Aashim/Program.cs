//Aashim Salhotra C0911959
//Assignment 2: 

Console.Write("Please enter a real number: ");
double x = double.Parse(Console.ReadLine());

bool belongs = (x >= 2 && x < 3) || (x >= 0 && x <= 1) || (x >= -10 && x <= -2);

if (belongs)
{Console.WriteLine("x belongs to I");}
else
{Console.WriteLine("x does not belong to I");}

