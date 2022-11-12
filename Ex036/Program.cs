/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


int[] InitArray(int n)
{
    int[] result = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        result[i] = rnd.Next(-99,100);
    }
    return result;
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

bool numberIsExist = false;

var summ = 0;
int[] array = InitArray(4);
Print(array);
for (int i = 1; i < array.Length; i+=2)
{
    summ = summ + array[i];
    numberIsExist = true;
}

if(numberIsExist)
{
    Console.WriteLine($"Сумма нечетных чисел {summ} ");
}
else
{
    Console.WriteLine("Ошибка");
}


