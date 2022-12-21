// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите любые числа через запятую: ");
string nums = Console.ReadLine();


string [] textArray = nums.Split(",");
int[] numArray = textArray.Select(int.Parse).ToArray();


Console.WriteLine(HowManyPositiveNum(numArray));



int HowManyPositiveNum (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0) sum +=1;
    }
return sum;
}




