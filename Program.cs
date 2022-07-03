// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string number = Console.ReadLine();
Console.WriteLine();


{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"your number: {number} is palindrome");
    }
    else
    {
        Console.WriteLine($"your number: {number} is not a palindrome");
    }
}




// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double ShowDistance (double x1, double y1, double z1, double x2, double y2, double z2)
// {
// double lineX = x2-x1;
// double lineY = y2-y1;
// double lineZ = z2-z1;

// double DistQuad = lineX*lineX + lineY*lineY + lineZ*lineZ;
// double result = Math.Sqrt(DistQuad); 

// return result;
// }

// Console.WriteLine("enter x coordinate: ");
// lineX = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("enter y coordinate: ");
// lineY = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("enter z coordinate: ");
// lineZ = Convert.ToInt32(Console.ReadLine());

// ShowDistance(result);









