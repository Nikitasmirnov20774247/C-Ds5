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
    numbers[i] = new Random().Next(-10,99);
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

int sum = 0;

for (int p = 0; p < numbers.Length; p+=2)
{
    sum += numbers[p];
}
Console.Write($"Cумма элементов на нечётных позициях = {sum}");