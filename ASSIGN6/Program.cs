// See https://aka.ms/new-console-template for more information
// 6. Write a program to enter marks of five subjects and calculate total, average and percentage ?

int maths, physics, english, arts, bio, total;

Console.WriteLine("input the marks of maths");
maths = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input the marks of physics");
physics = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input the marks of english");
english = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input the marks of arts");
arts = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input the marks of bio");
bio = Convert.ToInt32(Console.ReadLine());

total = maths + physics + english + arts + bio;

double average = (total / 5.0);

Console.WriteLine(average);

double percentage = total * (500 / 100);

Console.WriteLine(percentage);

