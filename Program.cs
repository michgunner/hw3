//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


bool IsPalindrome(long number)
{
   int digitsCount = number.ToString().Length;
   double firstHalfNumbers = 0;
   double secoundHalfNumbers = 0;
   int divider = 10;
   if (digitsCount>1 || number <0)
   {
      for (int i = 0; i < digitsCount/2; i++)
      {

         firstHalfNumbers = Math.Floor(number/(Math.Pow(10, digitsCount-i-1)) % 10); /* divide given number by 10 in grade of serial number of digit I want
                                                                                     and then get a reminder of it (the number I want)*/

         secoundHalfNumbers = Math.Floor((number % divider) / Math.Pow(10, i));
         if(secoundHalfNumbers!=firstHalfNumbers)
         {
            return false;
         }
         divider*=10;
      }
      return true;
   } else return false;
}

Console.Write("Please, enter your number: ");
long number = Convert.ToInt64(Console.ReadLine());

if (IsPalindrome(number))
   Console.WriteLine($"Yup! The number {number} is a palindrome.");
else 
   Console.WriteLine($"Yikes! The number {number} is not a palindrome.");




//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double DistanceBetween2Dots(double xA, double yA, double zA, double xB, double yB, double zB)
{
   double xDiff = Math.Pow((xA-xB), 2);
   double yDiff = Math.Pow((yA-yB), 2);
   double zDiff = Math.Pow((zA-zB), 2);
   double result = Math.Sqrt(xDiff+yDiff+zDiff);
   return result;
}

Console.WriteLine("Please, input X for first dot: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, input Y for first dot: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, input Z for first dot: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please, input X for secound dot: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, input Y for secound dot: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, input Z for secound dot: ");
double zB = Convert.ToDouble(Console.ReadLine());

double result = Math.Round(DistanceBetween2Dots(xA, yA, zA, xB, yB, zB), 2);
Console.WriteLine("Distance between 2 dots is: " + result);



//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void TableOfCubes(int number)
{
   for(int i = 1; i<=number; i++)
   {
      if(i==number) 
         Console.Write(Math.Pow(i, 3) + ".");
      else 
         Console.Write(Math.Pow(i, 3) + ", ");
   }
}

Console.WriteLine("Please, enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
TableOfCubes(number);