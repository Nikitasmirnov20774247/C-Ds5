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
    numbers[i] = new Random().Next(1,99);
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

int max = numbers[0];
int min = numbers[0];

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}
Console.WriteLine($"Max = {max}, Min = {min}");
Console.WriteLine($"Разница между Max и Min = {max - min}");
