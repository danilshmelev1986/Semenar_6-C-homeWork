// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Console.WriteLine ("give me a number of array length");
// int M = Convert.ToInt32(Console.ReadLine());

// int [] array = new int [M]; 

// for (int i=0; i<M; i++)
// {
//     Console.WriteLine ("give me a number");
//     int arrayNumber = Convert.ToInt32(Console.ReadLine());
//     array[i]=arrayNumber;
    
// }
// Console.Write("Array contents: ");
//         for (int i = 0; i < M; i++)
//         {
//             Console.Write(array[i] + "; ");
//         }
        
//         Console.WriteLine ();
        
//         int count = 0;
//         for (int i = 0; i < M; i++)
         
//         {
//             if (array[i]>0)
//             {
//             count++;
//             }
//         }
        
//         Console.Write("Numbers greater than zero in the array = "+count);





// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine ("give me a number k1");
 double k1 = Convert.ToDouble(Console.ReadLine());
 
 Console.WriteLine ("give me a number k2");
 double k2 = Convert.ToDouble(Console.ReadLine());
 
 Console.WriteLine ("give me a number b1");
 double b1 = Convert.ToDouble(Console.ReadLine());
 
 Console.WriteLine ("give me a number b2");
 double b2 = Convert.ToDouble(Console.ReadLine());
 
 if (k1==k2 && b1!=b2)
 {
    Console.WriteLine ("the lines is parallel"); 
 }
    else if (k1==k2 && b1==b2)
    {
        Console.WriteLine ("the lines is match");
            }
            else
            {
                
 double x = (b2 - b1) / (k1 - k2);
 double y = k1 * x + b1;
 
 Console.WriteLine ("coordinat cross point is: "+x+" "+y);
 
            }