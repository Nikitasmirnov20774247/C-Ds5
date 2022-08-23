Console.Write("Введите размер массива - ");
int size = Convert.ToInt32(Console.ReadLine());

if (size < 1)
{
    Console.Write("!! Размер массива не может быть отрицательным или равен нулю !!");
    return;
}

int[] numbers = new int[size];
for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(1,999);
}

void WriteArray(int[] numbers)
{
    Console.Write("[");
    int i = 0;
    int count = numbers.Length;

    while (i < count)
    {
        Console.Write(numbers[i]); i++;
        if (i < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.Write("Результат формирования массива: ");
WriteArray(numbers);

int count = 0;
for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] % 2 == 0) count++;
}

Console.WriteLine($"Количество чётных чисел в массиве = {count}");